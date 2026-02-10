namespace StockBuddy
{
    partial class Checkout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtScan = new System.Windows.Forms.TextBox();
            this.CheckoutBtn = new System.Windows.Forms.Button();
            this.headerLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtScan
            // 
            this.txtScan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtScan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScan.Location = new System.Drawing.Point(12, 147);
            this.txtScan.Multiline = true;
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(191, 32);
            this.txtScan.TabIndex = 0;
            this.txtScan.TextChanged += new System.EventHandler(this.txtScan_TextChanged);
            // 
            // CheckoutBtn
            // 
            this.CheckoutBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckoutBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutBtn.Location = new System.Drawing.Point(38, 331);
            this.CheckoutBtn.Name = "CheckoutBtn";
            this.CheckoutBtn.Size = new System.Drawing.Size(155, 99);
            this.CheckoutBtn.TabIndex = 1;
            this.CheckoutBtn.Text = "Checkout";
            this.CheckoutBtn.UseVisualStyleBackColor = true;
            this.CheckoutBtn.Click += new System.EventHandler(this.CheckoutBtn_Click);
            // 
            // headerLbl
            // 
            this.headerLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headerLbl.AutoSize = true;
            this.headerLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.ForeColor = System.Drawing.Color.White;
            this.headerLbl.Location = new System.Drawing.Point(352, 117);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(261, 27);
            this.headerLbl.TabIndex = 2;
            this.headerLbl.Text = "Number | Name | Price";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.ForeColor = System.Drawing.Color.White;
            this.totalLbl.Location = new System.Drawing.Point(532, 449);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(81, 27);
            this.totalLbl.TabIndex = 3;
            this.totalLbl.Text = "Total: ";
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(224, 147);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(516, 299);
            this.txtLog.TabIndex = 4;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.headerLbl);
            this.Controls.Add(this.CheckoutBtn);
            this.Controls.Add(this.txtScan);
            this.Name = "Checkout";
            this.ShowIcon = false;
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScan;
        private System.Windows.Forms.Button CheckoutBtn;
        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.TextBox txtLog;
    }
}