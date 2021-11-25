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
    public partial class GuessNumber : Form
    {
        Guess guess = new Guess();
        public GuessNumber()
        {
            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {                       
            Random r = new Random();
            guess.answer = r.Next(1, 101);
            guess.low = 1;
            guess.high = 100;
            Class1.gn = this;
            guess.ShowDialog();
           
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Answer : " + guess.answer);
        }

    }
}
