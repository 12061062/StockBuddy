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
    public partial class InventoryPaswordPrompt : Form
    {

        public string Password => textBox1.Text;

        public InventoryPaswordPrompt(string prompt = "Enter password:")
        {
            InitializeComponent();
            textBox1.Text = prompt;
            textBox1.PasswordChar = '*';
            ControlBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
