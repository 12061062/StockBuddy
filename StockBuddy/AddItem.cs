using StockBuddy.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockBuddy
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }


        private void ClearInputs()
        {
            txtName.Clear();
            txtS.Clear();
            txtBarcode.Clear();
            txtPrice.Clear();
            txtCost.Clear();
            txtQty.Clear();
            txtReorder.Clear();
            txtName.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1) Read + validate input
            var name = txtName.Text.Trim();
            var sku = txtS.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name is required.");
                return;
            }

            if (!long.TryParse(txtBarcode.Text.Trim(), out long barcode))
            {
                MessageBox.Show("Barcode must be a number.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price))
            {
                MessageBox.Show("Price must be a valid number.");
                return;
            }

            decimal cost = 0m;
            if (!string.IsNullOrWhiteSpace(txtCost.Text) &&
                !decimal.TryParse(txtCost.Text.Trim(), out cost))
            {
                MessageBox.Show("Cost must be a valid number.");
                return;
            }

            int qty = 0;
            if (!string.IsNullOrWhiteSpace(txtQty.Text) &&
                !int.TryParse(txtQty.Text.Trim(), out qty))
            {
                MessageBox.Show("Quantity must be a whole number.");
                return;
            }

            int reorder = 0;
            if (!string.IsNullOrWhiteSpace(txtReorder.Text) &&
                !int.TryParse(txtReorder.Text.Trim(), out reorder))
            {
                MessageBox.Show("Reorder Level must be a whole number.");
                return;
            }

            // 2) Insert into SQLite
            try
            {
                using (var conn = new SQLiteConnection(Database.ConnString))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"
INSERT INTO Products (Name, SKU, Barcode, Price, Cost, QuantityOnHand, ReorderLevel, IsActive)
VALUES (@name, @sku, @barcode, @price, @cost, @qty, @reorder, 1);
";
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@sku", sku);
                        cmd.Parameters.AddWithValue("@barcode", barcode);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@cost", cost);
                        cmd.Parameters.AddWithValue("@qty", qty);
                        cmd.Parameters.AddWithValue("@reorder", reorder);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Item added successfully!");
                ClearInputs();
            }
            catch (SQLiteException ex)
            {
                // Common: UNIQUE constraint failed: Products.Barcode
                if (ex.Message != null && ex.Message.ToLower().Contains("unique"))
                    MessageBox.Show("That barcode already exists. Please use a different barcode.");
                else
                    MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }
    }
}
