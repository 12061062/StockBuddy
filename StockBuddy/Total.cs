using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace StockBuddy
{
    public partial class Total : Form
    {
        decimal total;
        public Total(decimal total)
        {
            InitializeComponent();
            this.total = total;
            subtotalTxt.Text += $"${total.ToString()}";

            decimal tax = Math.Round(total * .0925m, 2);
            taxLbl.Text += $"${tax}";
            totalLbl.Text += $"${Math.Round(total + tax, 2)}";
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
                MessageBox.Show("Receipt emailed successfully!");
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
