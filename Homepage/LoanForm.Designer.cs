namespace Homepage
{
    partial class LoanForm
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
            this.LoanMoney = new System.Windows.Forms.Label();
            this.DeadLine = new System.Windows.Forms.Label();
            this.Rate = new System.Windows.Forms.Label();
            this.PayMent = new System.Windows.Forms.Label();
            this.textLoanMoney = new System.Windows.Forms.TextBox();
            this.textPayMent = new System.Windows.Forms.TextBox();
            this.textRate = new System.Windows.Forms.TextBox();
            this.textDeadLine = new System.Windows.Forms.TextBox();
            this.btnPMT = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoanMoney
            // 
            this.LoanMoney.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LoanMoney.Location = new System.Drawing.Point(91, 37);
            this.LoanMoney.Name = "LoanMoney";
            this.LoanMoney.Size = new System.Drawing.Size(100, 30);
            this.LoanMoney.TabIndex = 0;
            this.LoanMoney.Text = "貸款金額";
            this.LoanMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeadLine
            // 
            this.DeadLine.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DeadLine.Location = new System.Drawing.Point(91, 86);
            this.DeadLine.Name = "DeadLine";
            this.DeadLine.Size = new System.Drawing.Size(100, 30);
            this.DeadLine.TabIndex = 1;
            this.DeadLine.Text = "期限(年)";
            this.DeadLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Rate
            // 
            this.Rate.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Rate.Location = new System.Drawing.Point(91, 134);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(100, 30);
            this.Rate.TabIndex = 2;
            this.Rate.Text = "利率(%)";
            this.Rate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PayMent
            // 
            this.PayMent.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PayMent.Location = new System.Drawing.Point(91, 181);
            this.PayMent.Name = "PayMent";
            this.PayMent.Size = new System.Drawing.Size(100, 29);
            this.PayMent.TabIndex = 3;
            this.PayMent.Text = "頭期款";
            this.PayMent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textLoanMoney
            // 
            this.textLoanMoney.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textLoanMoney.Location = new System.Drawing.Point(207, 37);
            this.textLoanMoney.Multiline = true;
            this.textLoanMoney.Name = "textLoanMoney";
            this.textLoanMoney.Size = new System.Drawing.Size(139, 29);
            this.textLoanMoney.TabIndex = 4;
            this.textLoanMoney.Text = "100000";
            // 
            // textPayMent
            // 
            this.textPayMent.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textPayMent.Location = new System.Drawing.Point(207, 181);
            this.textPayMent.Multiline = true;
            this.textPayMent.Name = "textPayMent";
            this.textPayMent.Size = new System.Drawing.Size(139, 29);
            this.textPayMent.TabIndex = 5;
            this.textPayMent.Text = "0";
            // 
            // textRate
            // 
            this.textRate.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textRate.Location = new System.Drawing.Point(207, 135);
            this.textRate.Multiline = true;
            this.textRate.Name = "textRate";
            this.textRate.Size = new System.Drawing.Size(139, 29);
            this.textRate.TabIndex = 6;
            this.textRate.Text = "10";
            // 
            // textDeadLine
            // 
            this.textDeadLine.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textDeadLine.Location = new System.Drawing.Point(207, 86);
            this.textDeadLine.Multiline = true;
            this.textDeadLine.Name = "textDeadLine";
            this.textDeadLine.Size = new System.Drawing.Size(139, 29);
            this.textDeadLine.TabIndex = 7;
            this.textDeadLine.Text = "2";
            // 
            // btnPMT
            // 
            this.btnPMT.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPMT.Location = new System.Drawing.Point(95, 257);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(124, 42);
            this.btnPMT.TabIndex = 10;
            this.btnPMT.Text = "PMT(月付)";
            this.btnPMT.UseVisualStyleBackColor = true;
            this.btnPMT.Click += new System.EventHandler(this.btnPMT_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotal.Location = new System.Drawing.Point(258, 257);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(119, 42);
            this.btnTotal.TabIndex = 11;
            this.btnTotal.Text = "總付款";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(416, 257);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(119, 42);
            this.btnReport.TabIndex = 12;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 351);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnPMT);
            this.Controls.Add(this.textDeadLine);
            this.Controls.Add(this.textRate);
            this.Controls.Add(this.textPayMent);
            this.Controls.Add(this.textLoanMoney);
            this.Controls.Add(this.PayMent);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.DeadLine);
            this.Controls.Add(this.LoanMoney);
            this.Name = "LoanForm";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoanMoney;
        private System.Windows.Forms.Label DeadLine;
        private System.Windows.Forms.Label Rate;
        private System.Windows.Forms.Label PayMent;
        private System.Windows.Forms.TextBox textLoanMoney;
        private System.Windows.Forms.TextBox textPayMent;
        private System.Windows.Forms.TextBox textRate;
        private System.Windows.Forms.TextBox textDeadLine;
        private System.Windows.Forms.Button btnPMT;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnReport;
    }
}