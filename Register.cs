using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagementSystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void cb_show_pass_CheckedChanged(object sender, EventArgs e)
        {
            tb_pass.PasswordChar = cb_show_pass.Checked ? '\0' : '•';
            tb_pass_confirm.PasswordChar = cb_show_pass.Checked ? '\0' : '•';
        }
    }
}
