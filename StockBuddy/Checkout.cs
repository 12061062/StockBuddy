using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;
using StockBuddy.Data;

namespace StockBuddy
{
    public partial class Checkout : Form
    {
        private readonly List<Item> cart = new List<Item>();
        decimal total;

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
            var showTotal = new Total(total);
            showTotal.ShowDialog();
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
            using (var conn = new SQLiteConnection(Database.ConnString))
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
SELECT Name, Barcode, Price
FROM Products
WHERE Barcode = @barcode AND IsActive = 1;
";
                    cmd.Parameters.AddWithValue("@barcode", scanNumber);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return null;

                        return new Item
                        {
                            itemName = reader.GetString(0),
                            itemNum = reader.GetInt64(1),
                            itemPrice = Convert.ToDecimal(reader.GetDouble(2))
                        };
                    }
                }
            }
        }

        private void UpdateTotal()
        {
            total = cart.Sum(i => i.itemPrice);
            totalLbl.Text = $"Total: ${total:0.00}";
        }
    }
}
