using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

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
                    string entered = dlg.Password.Trim();

                    string storedHash = manage
                        ? ConfigurationManager.AppSettings["ManagePasswordHash"]
                        : ConfigurationManager.AppSettings["CheckoutPasswordHash"];

                    bool valid = !string.IsNullOrEmpty(storedHash) &&
                                 PasswordHasher.Verify(entered, storedHash);

                    if (valid)
                    {
                        MessageBox.Show("Access granted");

                        if (manage)
                        {
                            using (var manageModal = new Manage())
                            {
                                manageModal.ShowDialog(this);
                            }
                        }
                        else
                        {
                            using (var checkout = new Checkout())
                            {
                                checkout.ShowDialog(this);
                            }
                        }

                        return true;
                    }

                    MessageBox.Show("Incorrect password");
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
