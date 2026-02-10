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
        InventoryPaswordPrompt inventoryPaswordPrompt = new InventoryPaswordPrompt();
        bool manage;
        bool formType;
        Checkout checkout = new Checkout();
        public Home()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimumSize = MaximumSize = new Size(993, 628);
        }

        private void CheckoutBtn_Click(object sender, EventArgs e)
        {
            ShowPasswordPrompt(manage);
        }

        private void InventoryBtn_Click(object sender, EventArgs e)
        {
            ShowPasswordPrompt(manage);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            InventoryBtn.BringToFront();
            CheckoutBtn.BringToFront();
        }

        private bool ShowPasswordPrompt(bool manage)
        {
            using (var dlg = new InventoryPaswordPrompt(""))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    string entered = dlg.Password;

                    // TODO: validate entered password (prefer hashed check in DB)
                    if (manage && entered == "test") // placeholder
                    {
                        MessageBox.Show("Access granted");
                        return true;
                    }
                    else if (!manage && entered == "test2")
                    {
                        MessageBox.Show("Access granted");
                        checkout.ShowDialog();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password");
                    }
                }
                return false;
            }

        }
    }
}
