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
    public partial class Alarm : Form
    {
        private int timeleft;
        public Alarm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
            
            if (checkBoxSet.Checked) //有無勾選
            {
                DateTime time;   
                DateTime.TryParse(maskedTextBox1.Text, out time); //將user填的時間字串轉換為datetime格式
                if (labelTime.Text == time.ToString("HH:mm:ss")) //比對時間
                {
                    AlertTimer.Start(); //啟動警報
                }
            }
            else
            {
                this.BackColor = DefaultBackColor;
                timeleft = 20;
            }
        }

        private void AlertTimer_Tick(object sender, EventArgs e)
        {
            if(timeleft == 0)
            {
                AlertTimer.Stop();
            }
            if (timeleft % 2 == 0)
            {
                this.BackColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.Red;
            }
            timeleft--;
        }
    }
}
