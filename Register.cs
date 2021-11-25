using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagementSystem.Controller;
using BookShopManagementSystem.Model;

namespace BookShopManagementSystem
{
    public partial class Register : Form
    {
        private readonly UserController _userController = new UserController();
        private readonly Regex _emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        private Home home;
        private Button btn_login;
        public Register(Home home, Button btn_login)
        {
            InitializeComponent();
            this.home = home;
            this.btn_login = btn_login;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            tb_pass.PasswordChar = '•';
            tb_pass_confirm.PasswordChar = '•';
            pnl_form.AutoScroll = true;
            pnl_form.AutoScrollMargin = new Size(10, 10);
        }

        private void cb_show_pass_CheckedChanged(object sender, EventArgs e)
        {
            tb_pass.PasswordChar = cb_show_pass.Checked ? '\0' : '•';
            tb_pass_confirm.PasswordChar = cb_show_pass.Checked ? '\0' : '•';
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string name = tb_name.Text.Trim();
            string surname = tb_surname.Text.Trim();
            string address = tb_adress.Text.Trim();
            string email = tb_email.Text.Trim();
            string password = tb_pass.Text.Trim();
            string passwordAgain = tb_pass_confirm.Text.Trim();
            bool isSeller = cb_is_seller.Checked;
            if (!(String.IsNullOrEmpty(Name) || String.IsNullOrEmpty(surname) ||
                                                 String.IsNullOrEmpty(address) ||
                                                 String.IsNullOrEmpty(email) ||
                                                 String.IsNullOrEmpty(password)))
            {
                if (_emailRegex.IsMatch(email))
                {
                    if (password.Length >= 6)
                    {
                        if (String.Equals(password, passwordAgain))
                        {

                            RegisterModel user = new RegisterModel()
                            {
                                Name = name,
                                Surname = surname,
                                Adress = address,
                                Email = email,
                                IsSeller = isSeller,
                                Password = password,
                            };
                            bool isRegistered = _userController.AddUser(user);
                            if (isRegistered)
                            {
                                //sb.AppendFormat("Congratulations, {0} registered successfully.", name);
                                home.AddNewForm(btn_login, "LOGIN");
                            }
                            else sb.Append("Email has already registered.");
                        }
                        else sb.Append("Passwords not match.");
                    }
                    else sb.Append("Password must be at least 6 character.");
                }
                else sb.Append("Email is not valid.");
            }
            else sb.Append("Fill all fields.");

            lbl_status.Text = sb.ToString();
            lbl_status.ForeColor = Color.Maroon;
        }


    }
}
