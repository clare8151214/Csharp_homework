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
    public partial class ScreenSaver : Form
    {
        private Point MouseLocation;
        private int left = 2;
        private int top = 2;
        public ScreenSaver()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void ScreenSaver_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += left;
            pictureBox1.Top += top;
            if (pictureBox1.Left + pictureBox1.Width > this.Width || pictureBox1.Left < 0)
            {
                left = -left;
            }
            if (pictureBox1.Top + pictureBox1.Height > this.Height || pictureBox1.Top < 0)
            {
                top = -top;
            }
        }

        private void ScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {
            if (!MouseLocation.IsEmpty)
            {
                if (Math.Abs(MouseLocation.X - e.X) > 5 ||Math.Abs(MouseLocation.Y - e.Y) > 5)
                    Close();
            }
            MouseLocation = e.Location;
        }
    }
}
