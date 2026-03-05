using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using StockBuddy.Data;

namespace StockBuddy
{
    public partial class RemoveItem : Form
    {
        public RemoveItem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(textBox1.Text.Trim(), out long barcode))
            {
                MessageBox.Show("Please enter a valid barcode.");
                return;
            }

            try
            {
                using (var conn = new SQLiteConnection(Database.ConnString))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM Products WHERE Barcode = @barcode;";
                        cmd.Parameters.AddWithValue("@barcode", barcode);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows == 0)
                        {
                            MessageBox.Show("Item not found.");
                        }
                        else
                        {
                            MessageBox.Show("Item deleted successfully.");
                            textBox1.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting item:\n" + ex.Message);
            }
        }
    }
}
