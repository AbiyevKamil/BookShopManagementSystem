using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private Home home;
        private User user;
        public ShopCenter(Home home)
        {
            InitializeComponent();
            this.home = home;
        }
        private void ShopCenter_Load(object sender, EventArgs e)
        {
            pnl_shop.AutoScroll = true;
            pnl_shop.AutoScrollMargin = new Size(10, 10);
            user = _userController.GetUserDataFromLocal();
            if (user == null)
            {
                lbl_user.Text = "Not signed in";
                lbl_user.ForeColor = Color.Maroon;
                lbl_bought_books.Text += " 0";
                lbl_budget.Text += " 0";
                btn_logout.Visible = false;
                btn_logout.IsAccessible = false;
                btn_sell_book.Visible = false;
                btn_sell_book.IsAccessible = false;
                btn_login.Visible = true;
                btn_login.IsAccessible = true;
            }
            else
            {
                btn_login.Visible = false;
                btn_login.IsAccessible = false;
                lbl_user.Text += $"{user.Name.ToUpper()} {user.Surname.ToUpper()}";
                lbl_budget.Text += $" {user.Budget}";
                lbl_bought_books.Text += $"";
            }

            DataContext context = new DataContext();
            var books = context.Books.Include(i => i.Image).ToList();
            foreach (var book in books)
            {
                GenerateItem(book.Id, book.Name, book.Author, book.Description, book.Category, book.PublishedDate.ToString("yyyy MMMM dd"), book.Language, book.Stock, book.Price, book.Image.Data);
            }
        }

        private void ShopCenter_FormClosing(object sender, FormClosingEventArgs e)
        {
            _userController.DeleteLocalData();
            System.Environment.Exit(0);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            _userController.Logout();
            this.Hide();
            home.Show();
        }

        private void btn_sell_book_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookForm bf = new BookForm();
            bf.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            home.Show();
        }




        // Generators

        private int StartPointX = 236;
        private int StartPointY = 52;
        private int SizeX = 800;
        private int SizeY = 280;
        private int SpaceY = 300;

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
            panel.Controls.Add(GenerateBuy(itemName, stock));
            panel.Controls.Add(GeneratePrice(itemName, price));
            panel.Controls.Add(GeneratePhoto(itemName, bytes));
            panel.Controls.Add(GenerateAuth(itemName, auth));
            panel.Controls.Add(GenerateTitle(itemName, title));
            panel.Location = new Point(StartPointX, StartPointY);
            panel.Name = "pnl_book_item_" + itemName;
            panel.Size = new Size(SizeX, SizeY);
            panel.TabIndex = id;
            pnl_shop.Controls.Add(panel);
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

        public Button GenerateBuy(string itemName, int stock)
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
                button.IsAccessible = false;
                button.Visible = false;
            }
            else
                button.IsAccessible = stock > 0 ? true : false;
            button.UseVisualStyleBackColor = false;
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
            label.Text = category.Substring(0, 1).ToUpper() + category.Substring(1); ;
            return label;
        }


    }
}
