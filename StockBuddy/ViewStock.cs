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
    public partial class ViewStock : Form
    {
        public ViewStock()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(textBox1.Text.Trim(), out long barcode))
            {
                MessageBox.Show("Please scan or enter a valid barcode.");
                return;
            }

            try
            {
                using (var conn = new SQLiteConnection(Database.ConnString))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"
SELECT Name, QuantityOnHand, ReorderLevel
FROM Products
WHERE Barcode = @barcode AND IsActive = 1;
";
                        cmd.Parameters.AddWithValue("@barcode", barcode);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string name = reader.GetString(0);
                                int quantityOnHand = reader.GetInt32(1);
                                int reorderLevel = reader.GetInt32(2);

                                string message = $"Item: {name}\nStock Level: {quantityOnHand}";

                                if (quantityOnHand <= reorderLevel)
                                {
                                    message += $"\nLow Stock Alert: Reorder level is {reorderLevel}.";
                                }

                                MessageBox.Show(message, "Stock Information");
                            }
                            else
                            {
                                MessageBox.Show("Item not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving stock:\n" + ex.Message);
            }

            textBox1.Clear();
            textBox1.Focus();
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
