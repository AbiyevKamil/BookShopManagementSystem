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

namespace BookShopManagementSystem
{
    public partial class ShopCenter : Form
    {
        private readonly UserController _userController = new UserController();
        public ShopCenter()
        {
            InitializeComponent();
        }

        private void ShopCenter_FormClosing(object sender, FormClosingEventArgs e)
        {
            _userController.DeleteLocalData();
        }
    }
}
