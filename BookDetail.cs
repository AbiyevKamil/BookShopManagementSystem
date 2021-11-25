using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagementSystem.Controller;
using BookShopManagementSystem.Helper;

namespace BookShopManagementSystem
{
    public partial class BookDetail : Form
    {
        private readonly BookController _bookController = new BookController();
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
        public BookDetail(int id, string title, string auth, string desc, string category, string pd, string language, int stock, double price, byte[] bytes)
        {
            InitializeComponent();
            this.id = id;
            this.title = title;
            this.desc = desc;
            this.category = category;
            this.pd = pd;
            this.language = language;
            this.stock = stock;
            this.price = price;
            this.bytes = bytes;
        }

        private void BookDetail_Load(object sender, EventArgs e)
        {
            pnl_book_photo.BackgroundImage = ImageHelper.ByteArrayToImage(bytes);
            lbl_title.Text = $"Name: {title}";
            lbl_auth.Text = $"Author: {auth}";
            lbl_category.Text = $"Category: {category}";
            lbl_long_desc.Text = desc;
            lbl_id.Text = id.ToString();
            lbl_lang.Text = $"Language: {language}";
            lbl_pd.Text = pd;
            lbl_price.Text = $"Price: {price.ToString("C")}";
            if (stock > 0)
            {
                btn_buy.Visible = true;
                btn_buy.IsAccessible = true;
                lbl_stock.ForeColor = Color.Green;
                lbl_stock.Text = "In Stock";
                btn_buy.Click += new EventHandler(btn_buy_Click);
            }
            else
            {
                lbl_stock.ForeColor = Color.Maroon;
                btn_buy.Visible = true;
                btn_buy.IsAccessible = true;
                lbl_stock.Text = "Out of Stock";
            }
        }

        public void btn_buy_Click(object sender, EventArgs e)
        {
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
        }
    }
}
