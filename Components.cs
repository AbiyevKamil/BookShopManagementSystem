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
    public partial class Components : Form
    {
        public Components()
        {
            InitializeComponent();
        }

        private void pnl_book_item_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Panel");
        }
    }
}
