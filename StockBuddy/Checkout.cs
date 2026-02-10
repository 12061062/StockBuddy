using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StockBuddy
{
    public partial class Checkout : Form
    {
        private readonly List<Item> cart = new List<Item>();

        public Checkout()
        {
            InitializeComponent();
            txtScan.KeyDown += txtScan_KeyDown;
            txtScan.Multiline = true;
            txtScan.AcceptsReturn = true;
            txtScan.Focus();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            txtScan.Focus();
        }

        private void CheckoutBtn_Click(object sender, EventArgs e)
        {

        }

        private void txtScan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtScan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            e.SuppressKeyPress = true;

            if (!long.TryParse(txtScan.Text.Trim(), out long scannedNumber))
            {
                MessageBox.Show("Invalid scan.");
                txtScan.Clear();
                txtScan.Focus();
                return;
            }

            Item item = GetItemFromScan(scannedNumber);

            if (item == null)
            {
                MessageBox.Show("Item not found");
                txtScan.Clear();
                txtScan.Focus();
                return;
            }

            cart.Add(item);

            txtLog.AppendText($"{item.itemName} | ${item.itemPrice:0.00}{Environment.NewLine}");

            UpdateTotal();
            txtScan.Clear();
            txtScan.Focus();
        }

        private Item GetItemFromScan(long scanNumber)
        {
            // TEMP mock data
            if (scanNumber == 111111111111)
            {
                return new Item
                {
                    itemName = "Chocolate Bar",
                    itemNum = 111111111111,
                    itemPrice = 2m
                };
            }

            return null;
        }

        private void UpdateTotal()
        {
            decimal total = cart.Sum(i => i.itemPrice);
            totalLbl.Text = $"Total: ${total:0.00}";
        }
    }
}
