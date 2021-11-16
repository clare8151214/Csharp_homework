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
    public partial class MyClac : Form
    {
        public MyClac()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            double n1, n2;
            bool a = double.TryParse(txtN1.Text,out n1);
            bool b = double.TryParse(txtN2.Text, out n2);
            if (a == false || b == false)
                MessageBox.Show("請輸入數值");
            else
                txtAnswer.Text = (n1 + n2).ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1, n2;
            bool a = double.TryParse(txtN1.Text, out n1);
            bool b = double.TryParse(txtN2.Text, out n2);
            if (a == false || b == false)
                MessageBox.Show("請輸入數值");
            else
                txtAnswer.Text = (n1 - n2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double n1, n2;
            bool a = double.TryParse(txtN1.Text, out n1);
            bool b = double.TryParse(txtN2.Text, out n2);
            if (a == false || b == false)
                MessageBox.Show("請輸入數值");
            else
                txtAnswer.Text = (n1 * n2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double n1, n2;
            bool a = double.TryParse(txtN1.Text, out n1);
            bool b = double.TryParse(txtN2.Text, out n2);
            if (a == false || b == false)
                MessageBox.Show("請輸入數值");
            else
                txtAnswer.Text = (n1 / n2).ToString();
        }

        private void txtN1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
