using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagementSystem.Controller;
using BookShopManagementSystem.Helper;
using BookShopManagementSystem.Model;

namespace BookShopManagementSystem
{
    public partial class BookForm : Form
    {
        private BookController _bookController = new BookController();
        private UserController _userController = new UserController();
        private ImageModel image;
        public BookForm()
        {
            InitializeComponent();
        }

        private void btn_add_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                image = new ImageModel();
                image.Name = String.IsNullOrEmpty(tb_name.Text) ? "Image" : tb_name.Text;
                try
                {
                    image.Data = ImageHelper.ImageToByteArray(ofd.FileName);
                    image.ImageFormat = Path.GetExtension(ofd.FileName);
                }
                catch (Exception)
                {
                    // ignored
                }
            }
            return;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text.Trim();
            string auth = tb_auth.Text.Trim();
            string category = tb_category.Text.Trim();
            string desc = tb_desc.Text.Trim();
            string lang = tb_lang.Text.Trim();
            string stock = tb_stock.Text.Trim();
            string price = tb_price.Text.Trim();
            DateTime pd = DateTime.Parse(dtp_published_date.Text);

            //else
            //{
            if (!(String.IsNullOrEmpty(name) || String.IsNullOrEmpty(auth) || String.IsNullOrEmpty(category) ||
                      String.IsNullOrEmpty(desc) || String.IsNullOrEmpty(stock) || String.IsNullOrEmpty(lang) ||
                      String.IsNullOrEmpty(price)))
            {
                if (Regex.IsMatch(price, @"^\d+$") && Regex.IsMatch(stock, @"^\d+$"))
                {
                    if (image == null)
                    {
                        lbl_status.Text = "Choose image";
                    }
                    else
                    {
                        User user = _userController.GetUserDataFromLocal();
                        Book book = new Book()
                        {
                            Name = name,
                            Author = auth,
                            Category = category,
                            Description = desc,
                            Language = lang,
                            Stock = Int32.Parse(stock),
                            Price = Int32.Parse(price),
                            PublishedDate = pd,
                            UserId = user.Id
                        };
                        _bookController.AddBook(book, image);
                        this.Hide();
                        ShopCenter sc = new ShopCenter(new Home());
                        sc.Show();
                    }
                }
                else lbl_status.Text = "Price and stock must be number.";

            }
            else
            {
                lbl_status.Text = "Fill all fields.";
            }
            //}
        }

        private void tb_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShopCenter sc = new ShopCenter(new Home());
            sc.Show();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            dtp_published_date.BackColor = Color.FromArgb(230, 230, 230);
        }
    }
}
