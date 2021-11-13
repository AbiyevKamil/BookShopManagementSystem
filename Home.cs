using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagementSystem.Helper;
using BookShopManagementSystem.Model;
using System.Data.Entity;

namespace BookShopManagementSystem
{
    public partial class Home : Form
    {
        private DataContext context = new DataContext();
        private Button currentButton;
        private Form currentForm;
        public Home()
        {
            InitializeComponent();
            AddNewForm(btn_register, "REGISTER");
        }

        private void DisableAllButtons()
        {
            foreach (var button in pnl_menu.Controls)
            {
                if (button != null && button is Button)
                    (button as Button).BackColor = Color.FromArgb(26, 26, 42);
            }
        }

        public void AddNewForm(Button button, String formName)
        {
            if (button != currentButton)
            {
                DisableAllButtons();
                if (currentForm != null) currentForm.Close();
                button.BackColor = Color.FromArgb(225, 38, 93);
                switch (formName)
                {
                    case "REGISTER":
                        Register register = new Register(this, btn_login);
                        currentForm = register;
                        break;
                    case "LOGIN":
                        Login login = new Login(this);
                        currentForm = login;
                        break;
                    default:
                        Register defaultRegister = new Register(this, btn_login);
                        currentForm = defaultRegister;
                        break;
                }
                currentForm.TopLevel = false;
                currentForm.FormBorderStyle = FormBorderStyle.None;
                currentForm.Dock = DockStyle.Fill;
                this.pnl_body.Controls.Add(currentForm);
                this.pnl_body.Tag = currentForm;
                currentForm.BringToFront();
                currentForm.Show();
            }

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            AddNewForm((Button)sender, "REGISTER");
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            AddNewForm((Button)sender, "LOGIN");
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            ShopCenter sc = new ShopCenter();
            this.Hide();
            sc.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //Book book = context.Books.Include(i => i.Image).FirstOrDefault();
            //Image image = ImageHelper.ByteArrayToImage(book.Image.Data);
            //MessageBox.Show(image.Height.ToString());
        }
    }
}
