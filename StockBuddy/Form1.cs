using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockBuddy
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void CheckoutBtn_Click(object sender, EventArgs e)
        {

        }

        private void InventoryBtn_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            InventoryBtn.BringToFront();
            CheckoutBtn.BringToFront();
        }
    }
}
