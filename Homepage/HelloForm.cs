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
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void EnglishName_Click(object sender, EventArgs e)
        {

        }

        private void ChineseName_Click(object sender, EventArgs e)
        {

        }

        private void gender_Click(object sender, EventArgs e)
        {

        }

        private void zodiac_Click(object sender, EventArgs e)
        {

        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string name = txtChineseName.Text;
            string ename = txtEnglishName.Text;
            string gendor = txtGender.Text;
            string zodiac = txtZodiac.Text;

            MessageBox.Show("Hello, 我是" + name + ",\n英文名字是 " + ename + 
                "\n性別是" + gendor + ",\n星座是" + zodiac + ",\n很高興認識你。");
            

        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            string name = txtChineseName.Text;
            string ename = txtEnglishName.Text;
            string gendor = txtGender.Text;
            string zodiac = txtZodiac.Text;

            MessageBox.Show("Hi, 我是" + name + ",\n英文名字是 " + ename +
                "\n性別是" + gendor + ",\n星座是" + zodiac + ",\n很高興認識你。");
        }
    }
}
