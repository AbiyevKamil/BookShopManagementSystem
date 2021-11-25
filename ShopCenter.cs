using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagementSystem.Controller;
using BookShopManagementSystem.Helper;
using BookShopManagementSystem.Model;

namespace BookShopManagementSystem
{
    public partial class ShopCenter : Form
    {
        private readonly UserController _userController = new UserController();
        private readonly BookController _bookController = new BookController();
        private readonly SettingsController _settings = new SettingsController();
        private readonly ResourceManager rm;
        private string lang;
        private Home home;
        private User user;
        private List<Book> books;

        // Generator Values
        private int StartPointX = 236;
        private int StartPointY = 30;
        private int SizeX = 800;
        private int SizeY = 280;
        private int SpaceY = 300;


        public ShopCenter(Home home)
        {
            InitializeComponent();
            this.home = home;
            lang = _settings.GetLang();
            switch (lang)
            {
                case "AZE":
                    rm = new ResourceManager("BookShopManagementSystem.aze", Assembly.GetExecutingAssembly());
                    MakeAZE();
                    break;
            }
        }

        public void MakeAZE()
        {
            lbl_budget.Text = $"{rm.GetString("budget")}:";
            lbl_user.Text = $"{rm.GetString("signed")}: ";
            btn_login.Text = rm.GetString("login");
            btn_admin_panel.Text = rm.GetString("manage");
            btn_delete_account.Text = rm.GetString("deleteuser");
            btn_logout.Text = rm.GetString("logout");
            btn_search.Text = rm.GetString("search");
            btn_sell_book.Text = rm.GetString("sell");
            cmb_stock_filter.Items[cmb_stock_filter.FindStringExact("All")] = rm.GetString("all");
            cmb_stock_filter.Items[cmb_stock_filter.FindStringExact("In Stock")] = rm.GetString("instock");
            cmb_stock_filter.Items[cmb_stock_filter.FindStringExact("Out of Stock")] = rm.GetString("outstock");
            lbl_not_signed.Text = rm.GetString("notsigned");
            cmb_type.Items[cmb_type.FindStringExact("Name")] = rm.GetString("name");
            cmb_type.Items[cmb_type.FindStringExact("Category")] = rm.GetString("category");
            cmb_type.Items[cmb_type.FindStringExact("Author")] = rm.GetString("author");
            cmb_type.Items[cmb_type.FindStringExact("Language")] = rm.GetString("language");
        }

        private void ShopCenter_Load(object sender, EventArgs e)
        {
            StartPointY = pnl_body.AutoScrollPosition.Y;
            pnl_body.AutoScroll = true;
            pnl_body.AutoScrollMargin = new Size(10, 10);
            cmb_type.SelectedIndex = 0;
            cmb_stock_filter.SelectedIndex = 0;
            user = _userController.GetUserDataFromLocal();
            if (user == null)
            {
                lbl_user.Visible = false;
                lbl_not_signed.Visible = true;
                //lbl_bought_books.Text += " 0";
                lbl_budget.Visible = false;
                btn_logout.Visible = false;
                btn_logout.Enabled = false;
                btn_sell_book.Visible = false;
                btn_sell_book.Enabled = false;
                btn_login.Visible = true;
                btn_login.Enabled = true;
                btn_admin_panel.Visible = false;
                btn_admin_panel.Enabled = false;
                btn_delete_account.Visible = false;
                btn_delete_account.Enabled = false;
            }
            else
            {
                if (!user.IsSeller)
                {
                    btn_sell_book.Visible = false;
                    btn_sell_book.Enabled = false;
                    btn_admin_panel.Visible = false;
                    btn_admin_panel.Enabled = false;
                }
                else
                {
                    btn_delete_account.Visible = false;
                    btn_delete_account.Enabled = false;
                }
                btn_login.Visible = false;
                btn_login.Enabled = false;
                lbl_user.Visible = true;
                lbl_not_signed.Visible = false;
                lbl_user.Text += $"{user.Name.Substring(0, 1).ToString() + user.Name.Substring(1)} {user.Surname.Substring(0, 1) + user.Surname.Substring(1)}";
                lbl_budget.Text += $" {user.Budget.ToString("C")}";
            }

            FillBooks();
        }


        private void ShopCenter_FormClosing(object sender, FormClosingEventArgs e)
        {
            _userController.DeleteLocalData();
            _userController.Terminate();
            Environment.Exit(0);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            _userController.Logout();
            Hide();
            home.Show();
        }

        private void btn_sell_book_Click(object sender, EventArgs e)
        {
            Hide();
            BookForm bf = new BookForm(true);
            bf.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Hide();
            home.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //if (!String.IsNullOrEmpty(tb_query.Text))
            //{
            StartPointX = 236;
            StartPointY = pnl_body.AutoScrollPosition.Y;
            string query = tb_query.Text.Trim();
            int type = cmb_type.SelectedIndex;
            int inStock = cmb_stock_filter.SelectedIndex;
            books = _bookController.GetBookByQuery(query, type, inStock);
            pnl_body.Controls.Clear();
            foreach (var book in books)
            {
                GenerateItem(book.Id, book.Name, book.Author, book.Description, book.Category, book.PublishedDate.ToString("yyyy MMMM dd"), book.Language, book.Stock, book.Price, book.Image.Data);
            }
            //}
        }

        private void btn_admin_panel_Click(object sender, EventArgs e)
        {
            AccountPanel ap = new AccountPanel(this);
            ap.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            user = _userController.GetUserDataFromLocal();
            if (user != null)
            {
                lbl_budget.Text = lang == "AZE" ? $"Büdcə: {user.Budget.ToString("C")}" : $"Budget: {user.Budget.ToString("C")}";
            }

            tb_query.Text = "";
            cmb_type.SelectedIndex = 0;
            cmb_stock_filter.SelectedIndex = 0;
            FillBooks();
        }

        public void FillBooks()
        {
            StartPointX = 236;
            StartPointY = pnl_body.AutoScrollPosition.Y;
            books = _bookController.GetAllBooks();
            pnl_body.Controls.Clear();
            foreach (var book in books)
            {
                GenerateItem(book.Id, book.Name, book.Author, book.Description, book.Category, book.PublishedDate.ToString("yyyy MMMM dd"), book.Language, book.Stock, book.Price, book.Image.Data);
            }
        }

        // Generators


        public void GenerateItem(int id, string title, string auth, string desc, string category, string pd, string language, int stock, double price, byte[] bytes)
        {
            string itemName = id.ToString();
            Panel panel = new Panel();
            panel.Anchor = AnchorStyles.Top;
            panel.BackColor = Color.WhiteSmoke;
            panel.Controls.Add(GenerateCategory(itemName, category));
            panel.Controls.Add(GeneratePd(itemName, pd));
            panel.Controls.Add(GenerateLang(itemName, language));
            panel.Controls.Add(GenerateStock(itemName, stock));
            panel.Controls.Add(GenerateLongDesc(itemName, desc));
            panel.Controls.Add(GenerateDesc(itemName));
            panel.Controls.Add(GenerateId(itemName, id));
            panel.Controls.Add(GenerateMore(itemName, id, title, auth, desc, category, pd, language, stock, price, bytes));
            panel.Controls.Add(GenerateBuy(itemName, stock, id));
            panel.Controls.Add(GeneratePrice(itemName, price));
            panel.Controls.Add(GeneratePhoto(itemName, bytes));
            panel.Controls.Add(GenerateAuth(itemName, auth));
            panel.Controls.Add(GenerateTitle(itemName, title));
            panel.Location = new Point(StartPointX, StartPointY);
            panel.Name = "pnl_book_item_" + itemName;
            panel.Size = new Size(SizeX, SizeY);
            panel.TabIndex = id;
            pnl_body.Controls.Add(panel);
            StartPointY += SpaceY;
        }

        public Label GenerateTitle(string itemName, string title)
        {
            Label label = new Label();
            label.Name = "lbl_title_" + itemName;
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label.Location = new Point(25, 19);
            label.Size = new Size(108, 25);
            label.TabIndex = 0;
            label.Text = "Name: " + title;
            return label;
        }

        public Label GenerateAuth(string itemName, string auth)
        {
            Label label = new Label();
            label.Name = "lbl_auth_" + itemName;
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label.Location = new Point(25, 57);
            label.Size = new Size(217, 25);
            label.TabIndex = 0;
            label.Text = "Author: " + auth;
            return label;
        }

        public Panel GeneratePhoto(string itemName, byte[] bytes)
        {
            Panel panel = new Panel();
            //panel.AutoSize = true;
            //panel.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            Image image = ImageHelper.ByteArrayToImage(bytes);
            panel.BackgroundImage = image;
            panel.BackgroundImageLayout = ImageLayout.Stretch;
            panel.Location = new Point(650, 0);
            panel.Name = "pnl_book_photo_" + itemName;
            panel.Size = new Size(150, 150);
            panel.TabIndex = 2;
            return panel;
        }

        public Label GeneratePrice(string itemName, double price)
        {
            Label label = new Label();
            //label.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label.ForeColor = Color.Maroon;
            label.Location = new Point(682, 213);
            label.Name = "lbl_price_" + itemName;
            label.Size = new Size(115, 25);
            label.TabIndex = 3;
            label.Text = "Price: " + price.ToString("C");
            return label;
        }

        public Button GenerateBuy(string itemName, int stock, int id)
        {
            Button button = new Button();
            button.BackColor = Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            button.Cursor = Cursors.Hand;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.ForeColor = Color.White;
            button.Location = new Point(650, 241);
            button.Name = "btn_buy_" + itemName;
            button.Size = new Size(150, 39);
            button.TabIndex = 4;
            button.Text = "Buy";
            if (user == null)
            {
                button.Enabled = false;
                button.Visible = false;
            }
            else
            {
                button.Enabled = stock > 0 ? true : false;
                button.Click += new EventHandler(delegate (object sender, EventArgs e)
                {
                    // Buy Book
                    string bookDirectory = $@"C:/Users/{Environment.UserName}/Desktop/BookShop/{Name}";
                    bool status = _bookController.BuyBook(id);
                    if (status)
                    {
                        MessageBox.Show(
                            $"You bought {Name} book successfully. Now you can go to {bookDirectory} path and enjoy your new book. :)",
                            "Book Shop", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("You can't buy this book. This problem may occur in case of: \n1. The seller is you.\n2. You don't have enough budget.\n3. The book is out of stock.", "Book Shop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                });
            }

            button.UseVisualStyleBackColor = false;
            return button;
        }
        public Button GenerateMore(string itemName, int id, string title, string auth, string desc, string category, string pd, string language, int stock, double price, byte[] bytes)
        {
            Button button = new Button();
            button.BackColor = Color.Transparent;
            button.Cursor = Cursors.Hand;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            button.ForeColor = Color.DarkRed;
            button.Location = new Point(499, 0);
            button.Name = "btn_show_more_" + itemName;
            button.Size = new Size(150, 39);
            button.TabIndex = 6;
            button.Text = "More...";
            button.BackColor = Color.WhiteSmoke;
            if (user == null)
            {
                button.Visible = false;
                button.Enabled = false;
            }
            button.Click += new EventHandler(delegate (object sender, EventArgs e)
            {
                BookDetail bd = new BookDetail(id, title, auth, desc, category, pd, language, stock, price, bytes);
                bd.ShowDialog();
            });
            return button;
        }

        public Label GenerateId(string itemName, int id)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new Point(426, 19);
            label.Name = "lbl_id";
            label.Size = new Size(28, 25);
            label.TabIndex = 5;
            label.Text = id.ToString();
            label.Visible = false;
            return label;
        }
        public Label GenerateDesc(string itemName)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label.Location = new Point(25, 150);
            label.Name = "lbl_desc_" + itemName;
            label.Size = new Size(112, 25);
            label.TabIndex = 6;
            label.Text = "Description:";
            return label;
        }
        public Label GenerateLongDesc(string itemName, string desc)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label.Location = new Point(25, 182);
            label.MaximumSize = new Size(500, 100);
            label.Name = "lbl_long_desc";
            label.Size = new Size(129, 25);
            label.TabIndex = 7;
            label.Text = desc.Length > 200 ? desc.Substring(0, 197) + "..." : desc;
            return label;
        }

        public Label GenerateStock(string itemName, int stock)
        {
            Label label = new Label();
            //label.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label.Location = new Point(700, 182);
            label.Name = "lbl_stock_" + itemName;
            label.Size = new Size(77, 25);
            label.TabIndex = 8;
            if (stock > 0)
            {
                label.Text = "In Stock";
                label.ForeColor = Color.Green;
            }
            else
            {
                label.Text = "Out of Stock";
                label.ForeColor = Color.Maroon;
            }
            return label;
        }
        public Label GenerateLang(string itemName, string language)
        {
            Label label = new Label();
            //label.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label.Location = new Point(25, 120);
            label.Name = "lbl_lang_" + itemName;
            label.Size = new Size(95, 25);
            label.TabIndex = 9;
            label.Text = language.Substring(0, 1).ToUpper() + language.Substring(1);
            return label;
        }

        public Label GeneratePd(string itemName, string date)
        {
            Label label = new Label();
            //label.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label.Location = new Point(663, 153);
            label.Name = "lbl_pd_" + itemName;
            label.Size = new Size(134, 25);
            label.TabIndex = 10;
            label.Text = date;
            return label;
        }
        public Label GenerateCategory(string itemName, String category)
        {
            Label label = new Label();
            //label.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label.Location = new Point(25, 90);
            label.Name = "lbl_category_" + itemName;
            label.Size = new Size(88, 25);
            label.TabIndex = 11;
            label.Text = category.Substring(0, 1).ToUpper() + category.Substring(1);
            return label;
        }

        private void btn_delete_account_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to delete your account", "Book Shop", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                _userController.DeleteUser();
                _userController.Logout();
            }
            this.Hide();
            home.Show();
        }
    }
}
