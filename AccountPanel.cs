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
using BookShopManagementSystem.Model;

namespace BookShopManagementSystem
{
    public partial class AccountPanel : Form
    {
        private BookController _bookController = new BookController();
        public AccountPanel()
        {
            InitializeComponent();
        }

        private void AccountPanel_Load(object sender, EventArgs e)
        {
            dgw_books.AllowUserToAddRows = false;
            FillTable();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            BookForm bf = new BookForm(false);
            bf.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        public void FillTable()
        {
            var books = _bookController.GetUserBooks();
            if (books != null)
            {
                foreach (Book book in books)
                {
                    if (!String.IsNullOrEmpty(book.Name))
                    {
                        Image image = ImageHelper.ByteArrayToImage(book.Image.Data);
                        dgw_books.Rows.Add(book.Name, book.Author, book.Description, book.Category, book.Language, book.Price, book.Stock, book.PublishedDate.ToString("yyyy MMMM dd"), book.AddedDate.ToString("yyyy MMMM dd"), image);
                    }

                }
            }
        }
    }
}
