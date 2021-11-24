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
    public partial class Background : Form
    {
        public Background()
        {
            InitializeComponent();
            splitContainer2.SplitterWidth = 2;
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            HelloForm helloForm = new HelloForm();
            helloForm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(helloForm);
            helloForm.Show();
            
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            LoanForm loanForm = new LoanForm();
            loanForm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(loanForm);
            loanForm.Show();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            PosForm posForm = new PosForm();
            posForm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(posForm);
            posForm.Show();
        }

        private void btnStudent_StructForm_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Student_StructForm ssForm = new Student_StructForm();
            ssForm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(ssForm);
            ssForm.Show();
        }

        private void btnStudentsGrade_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            StudentsGrade ssForm = new StudentsGrade();
            ssForm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(ssForm);
            ssForm.Show();
        }

        private void btnStudentsGrade_List_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            StudentsGrade_List ssForm = new StudentsGrade_List();
            ssForm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(ssForm);
            ssForm.Show();
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Method mForm = new Method();
            mForm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(mForm);
            mForm.Show();
        }

        private void btnMyClac_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            MyClac mForm = new MyClac();
            mForm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(mForm);
            mForm.Show();
        }

        private void btnForDoWhile_Click(object sender, EventArgs e)
        {            
            splitContainer2.Panel2.Controls.Clear();
            ForDoWhile forForm = new ForDoWhile();
            forForm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(forForm);
            forForm.Show();
        }

        private void btnXOGame_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            XOGame xogForm = new XOGame();
            xogForm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(xogForm);
            xogForm.Show();
        }

        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            ScreenSaver ssForm = new ScreenSaver();
            ssForm.Show();
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            Notepad npForm = new Notepad();
            npForm.Show();
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            DrawPaint drawPaint = new DrawPaint();
            drawPaint.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(drawPaint);
            drawPaint.Show();
        }

        private void btnPictureViewer_Click(object sender, EventArgs e)
        {

        }
    }
}
