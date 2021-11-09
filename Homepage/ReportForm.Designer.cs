namespace Homepage
{
    partial class ReportForm
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
            this.Rate = new System.Windows.Forms.Label();
            this.DeadLine = new System.Windows.Forms.Label();
            this.LoanMoney = new System.Windows.Forms.Label();
            this.labelLoanMoney = new System.Windows.Forms.Label();
            this.labelDeadLine = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rate
            // 
            this.Rate.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Rate.Location = new System.Drawing.Point(91, 134);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(100, 30);
            this.Rate.TabIndex = 10;
            this.Rate.Text = "利率(%):";
            this.Rate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeadLine
            // 
            this.DeadLine.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DeadLine.Location = new System.Drawing.Point(91, 86);
            this.DeadLine.Name = "DeadLine";
            this.DeadLine.Size = new System.Drawing.Size(100, 30);
            this.DeadLine.TabIndex = 9;
            this.DeadLine.Text = "期限(年):";
            this.DeadLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoanMoney
            // 
            this.LoanMoney.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LoanMoney.Location = new System.Drawing.Point(91, 37);
            this.LoanMoney.Name = "LoanMoney";
            this.LoanMoney.Size = new System.Drawing.Size(100, 30);
            this.LoanMoney.TabIndex = 8;
            this.LoanMoney.Text = "貸款金額:";
            this.LoanMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLoanMoney
            // 
            this.labelLoanMoney.AutoSize = true;
            this.labelLoanMoney.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLoanMoney.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelLoanMoney.Location = new System.Drawing.Point(207, 37);
            this.labelLoanMoney.Name = "labelLoanMoney";
            this.labelLoanMoney.Size = new System.Drawing.Size(2, 26);
            this.labelLoanMoney.TabIndex = 14;
            this.labelLoanMoney.UseMnemonic = false;
            this.labelLoanMoney.Click += new System.EventHandler(this.labelLoanMoney_Click);
            // 
            // labelDeadLine
            // 
            this.labelDeadLine.AutoSize = true;
            this.labelDeadLine.BackColor = System.Drawing.Color.Transparent;
            this.labelDeadLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDeadLine.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelDeadLine.Location = new System.Drawing.Point(207, 86);
            this.labelDeadLine.Name = "labelDeadLine";
            this.labelDeadLine.Size = new System.Drawing.Size(2, 26);
            this.labelDeadLine.TabIndex = 15;
            this.labelDeadLine.UseMnemonic = false;
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.BackColor = System.Drawing.Color.Transparent;
            this.labelRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelRate.Location = new System.Drawing.Point(207, 136);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(2, 26);
            this.labelRate.TabIndex = 16;
            this.labelRate.UseMnemonic = false;
            // 
            // month
            // 
            this.month.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.month.Location = new System.Drawing.Point(91, 187);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(100, 30);
            this.month.TabIndex = 17;
            this.month.Text = "月付款:";
            this.month.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Total
            // 
            this.Total.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Total.Location = new System.Drawing.Point(91, 241);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(100, 30);
            this.Total.TabIndex = 18;
            this.Total.Text = "總付款:";
            this.Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.BackColor = System.Drawing.Color.Transparent;
            this.labelMonth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMonth.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelMonth.Location = new System.Drawing.Point(207, 189);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(2, 26);
            this.labelMonth.TabIndex = 19;
            this.labelMonth.UseMnemonic = false;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotal.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTotal.Location = new System.Drawing.Point(207, 243);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(2, 26);
            this.labelTotal.TabIndex = 20;
            this.labelTotal.UseMnemonic = false;
            // 
            // btnEmail
            // 
            this.btnEmail.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEmail.Location = new System.Drawing.Point(401, 275);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(111, 45);
            this.btnEmail.TabIndex = 21;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 354);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.month);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.labelDeadLine);
            this.Controls.Add(this.labelLoanMoney);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.DeadLine);
            this.Controls.Add(this.LoanMoney);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Rate;
        private System.Windows.Forms.Label DeadLine;
        private System.Windows.Forms.Label LoanMoney;
        public System.Windows.Forms.Label labelLoanMoney;
        public System.Windows.Forms.Label labelDeadLine;
        public System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.Label Total;
        public System.Windows.Forms.Label labelMonth;
        public System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button btnEmail;
    }
}