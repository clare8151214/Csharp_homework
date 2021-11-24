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
    public partial class DrawPaint : Form
    {
        Graphics g;
        Pen pen = new Pen(Color.Black, 1f);
        float oldX, oldY;
        public DrawPaint()
        {
            InitializeComponent();
            g = CreateGraphics();
            pictureBox1.BackColor = Color.Black;
            label1.Text = string.Concat(trackBar1.Value);          
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
            label1.Text = string.Concat(trackBar1.Value);
        }

        private void DrawPaint_MouseDown(object sender, MouseEventArgs e)
        {            
            oldX = e.X;
            oldY = e.Y;
        }

        private void DrawPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                g.DrawLine(pen, oldX, oldY, e.X, e.Y);
                oldX = e.X;
                oldY = e.Y;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                pictureBox1.BackColor = colorDialog1.Color;
            }
            
        }
    }
}
