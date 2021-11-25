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
        private readonly BookController _bookController = new BookController();
        private readonly UserController _userController = new UserController();
        private ShopCenter sc;
        public AccountPanel(ShopCenter sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void AccountPanel_Load(object sender, EventArgs e)
        {
            dgw_books.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_books.AllowUserToAddRows = false;
            ((DataGridViewImageColumn)dgw_books.Columns[dgw_books.ColumnCount - 1]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            FillTable();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            BookForm bf = new BookForm(false);
            bf.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        public void FillTable()
        {
            dgw_books.Rows.Clear();
            var books = _bookController.GetUserBooks();
            if (books != null)
            {
                foreach (Book book in books)
                {
                    Image image = ImageHelper.ByteArrayToImage(book.Image.Data);
                    dgw_books.Rows.Add(book.Id, book.Name, book.Author, book.Description, book.Category, book.Language, book.Price, book.Stock, book.PublishedDate.ToString("yyyy MMMM dd"), book.AddedDate.ToString("yyyy MMMM dd"), image);
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dgw_books.CurrentRow != null)
            {
                int id = (int)dgw_books.CurrentRow.Cells["Id"].Value;
                Book book = _bookController.GetBookById(id);
                if (book == null)
                {
                    MessageBox.Show("Oops... Something went wrong. Try again later.", "Book Shop", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    FillTable();
                }
                else
                {
                    BookUpdateForm buf = new BookUpdateForm(book.Id, book.Name, book.Author, book.Description, book.Category, book.PublishedDate.ToLongDateString(), book.Language, book.Stock, book.Price, book.Image.Data);
                    buf.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Choose book from table.", "Book Shop", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgw_books.CurrentRow != null)
            {
                int id = (int)dgw_books.CurrentRow.Cells["Id"].Value;
                DialogResult dr = MessageBox.Show("Are you sure that you want to delete this book?", "Book Shop", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    _bookController.DeleteBookById(id);
                }
            }
            else
                MessageBox.Show("Choose book from table.", "Book Shop", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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
            sc.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
