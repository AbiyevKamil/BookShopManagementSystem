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
    public partial class BookUpdateForm : Form
    {
        private BookController _bookController = new BookController();
        private UserController _userController = new UserController();
        private ImageModel image;
        private readonly int id;
        private readonly string title;
        private readonly string auth;
        private readonly string desc;
        private readonly string category;
        private readonly string pd;
        private readonly string language;
        private readonly int stock;
        private readonly double price;
        private readonly byte[] bytes;

        public BookUpdateForm(int id, string title, string auth, string desc, string category, string pd, string language, int stock, double price, byte[] bytes)
        {
            InitializeComponent();
            this.id = id;
            this.title = title;
            this.auth = auth;
            this.desc = desc;
            this.category = category;
            this.pd = pd;
            this.language = language;
            this.stock = stock;
            this.price = price;
            this.bytes = bytes;
        }

        private void BookUpdateForm_Load(object sender, EventArgs e)
        {
            tb_name.Text = title;
            tb_auth.Text = auth;
            tb_category.Text = category;
            tb_desc.Text = desc;
            tb_lang.Text = language;
            tb_stock.Text = stock.ToString();
            tb_price.Text = price.ToString();
            dtp_published_date.Text = pd;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string nameNew = tb_name.Text.Trim();
            string authNew = tb_auth.Text.Trim();
            string categoryNew = tb_category.Text.Trim();
            string descNew = tb_desc.Text.Trim();
            string langNew = tb_lang.Text.Trim();
            string stockNew = tb_stock.Text.Trim();
            string priceNew = tb_price.Text.Trim();
            DateTime pd = DateTime.Parse(dtp_published_date.Text);
            if (!(String.IsNullOrEmpty(nameNew) || String.IsNullOrEmpty(authNew) || String.IsNullOrEmpty(categoryNew) ||
                  String.IsNullOrEmpty(descNew) || String.IsNullOrEmpty(stockNew) || String.IsNullOrEmpty(langNew) ||
                  String.IsNullOrEmpty(priceNew)))
            {
                if (categoryNew.Length < 30 && langNew.Length < 30 && authNew.Length < 30 && Name.Length < 30)
                {
                    if ((Regex.IsMatch(priceNew, @"^\d+$") || Regex.IsMatch(priceNew, @"[+-]?([0-9]*[.])?[0-9]+")) && Regex.IsMatch(stockNew, @"^\d+$"))
                    {
                        Book book = new Book()
                        {
                            Id = id,
                            Name = nameNew,
                            Author = authNew,
                            Category = categoryNew,
                            Description = descNew,
                            Language = langNew,
                            Stock = Convert.ToInt32(stockNew),
                            Price = Convert.ToDouble(priceNew),
                            Image = image,
                            PublishedDate = pd,
                        };
                        bool status = _bookController.UpdateBook(book);
                        if (status)
                        {
                            MessageBox.Show("Updated", "Book Shop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else MessageBox.Show("Something went wrong. Try again later.", "Book Shop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else lbl_status.Text = "Price and stock must be number.";
                }
                else lbl_status.Text = "Name, Author, Category, Language can't be more than 30 character length";
            }
            else lbl_status.Text = "Fill all fields.";
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

        private void tb_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void tb_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
