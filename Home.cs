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
using System.Reflection;
using System.Resources;
using BookShopManagementSystem.Controller;

namespace BookShopManagementSystem
{
    public partial class Home : Form
    {
        private DataContext context = new DataContext();
        private SettingsController _settings = new SettingsController();
        private ResourceManager rm = new ResourceManager("BookShopManagementSystem.eng", Assembly.GetExecutingAssembly());
        private Button currentButton;
        private Form currentForm;
        private bool temp = false;
        public Home()
        {
            InitializeComponent();
            string savedLang = _settings.GetLang();
            switch (savedLang)
            {
                case "ENG":
                    cmb_lang.SelectedIndex = 0;
                    MakeENG();
                    break;
                case "AZE":
                    cmb_lang.SelectedIndex = 1;
                    MakeAZE();
                    break;
            }
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
            if (temp)
            {
                currentButton = null;
                temp = false;
            }
            if (button != currentButton)
            {
                currentButton = button;
                DisableAllButtons();
                if (currentForm != null) currentForm.Close();
                button.BackColor = Color.FromArgb(225, 38, 93);
                switch (formName)
                {
                    case "REGISTER":
                        Register register = new Register(this, btn_login, rm);
                        currentForm = register;
                        break;
                    case "LOGIN":
                        Login login = new Login(this, rm);
                        currentForm = login;
                        break;
                    default:
                        Register defaultRegister = new Register(this, btn_login, rm);
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
            ShopCenter sc = new ShopCenter(this);
            this.Hide();
            sc.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

            //Book book = context.Books.Include(i => i.Image).FirstOrDefault();
            //Image image = ImageHelper.ByteArrayToImage(book.Image.Data);
            //MessageBox.Show(image.Height.ToString());
        }

        public void MakeAZE()
        {
            rm = new ResourceManager("BookShopManagementSystem.aze", Assembly.GetExecutingAssembly());
            LangChange();
            _settings.SetLang("AZE");
        }

        public void MakeENG()
        {
            rm = new ResourceManager("BookShopManagementSystem.eng", Assembly.GetExecutingAssembly());
            LangChange();
            _settings.SetLang("ENG");

        }

        public void LangChange()
        {
            btn_login.Text = rm.GetString("login");
            btn_register.Text = rm.GetString("register");
            btn_continue.Text = rm.GetString("continue");
        }

        private void cmb_lang_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp = true;
            string lang = cmb_lang.SelectedItem.ToString();
            switch (lang)
            {
                case "ENG":
                    MakeENG();
                    break;
                case "AZE":
                    MakeAZE();
                    break;
            }
            if (currentButton != null)
                currentButton.PerformClick();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
