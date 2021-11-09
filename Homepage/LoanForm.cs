using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homepage
{
    public partial class LoanForm : Form
    {
        public LoanForm()
        {
            InitializeComponent();
        }

        public double pmt_Count(object sender,EventArgs e)
        {
            int loan = Convert.ToInt32(textLoanMoney.Text);
            int deadline = Convert.ToInt32(textDeadLine.Text);
            double rate = Convert.ToDouble(textRate.Text);
            int payment = Convert.ToInt32(textPayMent.Text);
            int totalLoan = loan - payment;
            int month = deadline * 12;
            double monthRate = rate / 12 * 0.01;
            return totalLoan* monthRate / (1 - 1 / Math.Pow(1 + monthRate, month));
        }

        
        private void btnPMT_Click(object sender, EventArgs e)
        {           
            double pmt = pmt_Count(sender,e);
            MessageBox.Show("月付額:" + Convert.ToString(Math.Round(pmt)) + "元");
        }
        
        private void btnTotal_Click(object sender, EventArgs e)
        {
            double pmt = pmt_Count(sender, e);
            int deadline = Convert.ToInt32(textDeadLine.Text);
            int month = deadline * 12;
            double total = Math.Round(pmt) * month;
            MessageBox.Show("總付款:" + Convert.ToString(total) + "元");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm();
            double pmt = pmt_Count(sender, e);
            int deadline = Convert.ToInt32(textDeadLine.Text);
            int month = deadline * 12;
            double total = Math.Round(pmt) * month;

            report.labelLoanMoney.Text = textLoanMoney.Text;
            report.labelDeadLine.Text = textDeadLine.Text;
            report.labelRate.Text = textRate.Text;
            report.labelMonth.Text = Convert.ToString(Math.Round(pmt));
            report.labelTotal.Text = Convert.ToString(total);
            report.Show();
        }
    }
}
