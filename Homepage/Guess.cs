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
    public partial class Guess : Form
    {
        public int answer = 0;
        public int low = 1, high = 100;
        public int g;
        public bool f;
        public Guess()
        {
            InitializeComponent();
        }

        public void btnOK_Click(object sender, EventArgs e)
        {
            f = int.TryParse(textBox1.Text , out g);
            Check(ref answer, ref low, ref high, g, f);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        public void Check(ref int answer, ref int low, ref int high, int guess, bool f)
        {
            if (f != true || guess > high || guess < low)
                MessageBox.Show("請輸入" + low + "~" + high + "之間的數字。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (guess > answer)
                {
                    high = guess;
                    Class1.gn.label1.Text = "Too Large !!!\nBetween " + low + " and " + high;
                }
                else if (guess < answer)
                {
                    low = guess;
                    Class1.gn.label1.Text = "Too Small !!!\nBetween " + low + " and " + high;
                }
                else
                {
                    MessageBox.Show("Congradulations!!! You got " + answer + "!!!");
                }

            }
        }
    }
}
