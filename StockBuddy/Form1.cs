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
        bool manage;
        bool correctPassword;
        public Home()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void CheckoutBtn_Click(object sender, EventArgs e)
        {
            manage = false;
            correctPassword = false;
            while (!correctPassword)
            {
                correctPassword = ShowPasswordPrompt(manage);
            }
        }

        private void InventoryBtn_Click(object sender, EventArgs e)
        {
            manage = true;
            correctPassword = false;
            while (!correctPassword)
            {
                correctPassword = ShowPasswordPrompt(manage);
            }
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

                    if (manage && entered == "test")
                    {
                        MessageBox.Show("Access granted");
                        Manage manageModal = new Manage();
                        manageModal.ShowDialog(this);
                        return true;
                    }
                    else if (!manage && entered == "test2")
                    {
                        MessageBox.Show("Access granted");
                        Checkout checkout = new Checkout();
                        checkout.ShowDialog();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password");
                    }
                }
                else if (dlg.DialogResult == DialogResult.Cancel)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
