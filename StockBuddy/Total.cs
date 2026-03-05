using StockBuddy.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace StockBuddy
{
    public partial class Total : Form
    {
        private List<Item> _cart = new List<Item>();

        decimal total;
        public Total(decimal total, List<Item> cart)
        {
            InitializeComponent();
            this.total = total;
            subtotalTxt.Text += $"${total.ToString()}";

            decimal tax = Math.Round(total * .0925m, 2);
            taxLbl.Text += $"${tax}";
            totalLbl.Text += $"${Math.Round(total + tax, 2)}";
            _cart = cart;
        }

        private void Total_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string customerEmail = emailTxt.Text.Trim();

            if (string.IsNullOrWhiteSpace(customerEmail))
            {
                MessageBox.Show("Please enter a customer email.");
                return;
            }

            try
            {
                button1.Enabled = false;

                await SendReceiptEmailAsync(customerEmail);

                // UPDATE INVENTORY
                List<string> reorderAlerts = new List<string>();

                using (var conn = new SQLiteConnection(Database.ConnString))
                {
                    conn.Open();

                    // group cart items by barcode to know how many were sold
                    var groupedItems = _cart
                        .GroupBy(i => i.itemNum)
                        .Select(g => new
                        {
                            Barcode = g.Key,
                            QuantitySold = g.Count()
                        });

                    foreach (var item in groupedItems)
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = @"
UPDATE Products
SET QuantityOnHand = QuantityOnHand - @qty
WHERE Barcode = @barcode;
";

                            cmd.Parameters.AddWithValue("@qty", item.QuantitySold);
                            cmd.Parameters.AddWithValue("@barcode", item.Barcode);
                            cmd.ExecuteNonQuery();
                        }

                        // Check reorder level
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = @"
SELECT Name, QuantityOnHand, ReorderLevel
FROM Products
WHERE Barcode = @barcode;
";

                            cmd.Parameters.AddWithValue("@barcode", item.Barcode);

                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string name = reader.GetString(0);
                                    int qty = reader.GetInt32(1);
                                    int reorder = reader.GetInt32(2);

                                    if (qty <= reorder)
                                    {
                                        reorderAlerts.Add($"{name} is low on stock ({qty} left)");
                                    }
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("Receipt emailed successfully!");

                if (reorderAlerts.Count > 0)
                {
                    MessageBox.Show(
                        "Reorder Alert:\n\n" + string.Join("\n", reorderAlerts),
                        "Low Inventory Warning"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send receipt:\n" + ex.Message);
            }
            finally
            {
                button1.Enabled = true;
            }
        }
        private async Task SendReceiptEmailAsync(string customerEmail)
        {
            // Calculate numbers
            decimal subtotal = total;
            decimal tax = Math.Round(subtotal * 0.0925m, 2);
            decimal grandTotal = Math.Round(subtotal + tax, 2);

            // Build receipt body (customize as you want)
            string subject = "Your StockBuddy Receipt";
            string body =
        $@"Thanks for your purchase!

Receipt
-------------------------
Subtotal: {subtotal:C}
Tax (9.25%): {tax:C}
Total: {grandTotal:C}

Date: {DateTime.Now:G}
";

            // SMTP settings (replace with your sender + provider settings)
            string fromEmail = "StockBuddy@example.com";

            // IMPORTANT: don't hardcode passwords in real apps.
            // For Gmail you typically need an App Password, not your normal password.
            string smtpUser = "jgun1062@gmail.com";
            string smtpPass = "zygn caoq oovu acxr";

            using (var message = new MailMessage())
            {
                message.From = new MailAddress(fromEmail, "StockBuddy");
                message.To.Add(customerEmail);
                message.Subject = subject;
                message.Body = body;        // Plain text
                message.IsBodyHtml = false; // set true if you make HTML

                using (var client = new SmtpClient("smtp.gmail.com", 587)) // example: Gmail SMTP
                {
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential(smtpUser, smtpPass);

                    await client.SendMailAsync(message);
                }
            }
        }

    }
}
