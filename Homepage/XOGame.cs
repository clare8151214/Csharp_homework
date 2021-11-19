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
    public partial class XOGame : Form
    {
        bool flag = true;
        int turn_count = 0;
        public XOGame()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (flag)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }
            flag = !flag;
            button.Enabled = false;

            turn_count++;

            check_Winner();
        }


        private void check_Winner()
        {
            bool winner = false;
            //橫
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                winner = true;

            //直
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                winner = true;

            //對角
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                winner = true;
            else if ((C1.Text == B2.Text) && (B2.Text == A3.Text) && (!C1.Enabled))
                winner = true;


            //MessageBox.Show("" + turn_count);
            if (winner == true)
            {
                if (flag == false)
                    MessageBox.Show("X 手獲勝!", "完局!");
                else
                    MessageBox.Show("O 手獲勝!", "完局!");
                resetBotton();
                turn_count = 0;
                flag = true;
            }
            else if(turn_count == 9 && winner == false)
            {
                MessageBox.Show("平手! 按下確定後重新開始", "完局!");
                resetBotton();
                turn_count = 0;
                flag = true;
            }
        }

        private void resetBotton()
        {
            foreach(Control c in panel1.Controls)
            {
                Button b = (Button)c;
                b.Enabled = true;
                b.Text = "";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetBotton();
            turn_count = 0;
            flag = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
