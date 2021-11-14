using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homepage
{
    public partial class Student_StructForm : Form
    {
        public Student_StructForm()
        {
            InitializeComponent();
        }

        public static T Min<T>(params T[] values)
        {
            return values.Min();
        }

        public static T Max<T>(params T[] values)
        {
            return values.Max();
        }
        struct MyGrade
        {
            public string name;
            public int chinese;
            public int english;
            public int math;
        }
        MyGrade grade;
        private void btnSave_Click(object sender, EventArgs e)
        {
            grade.name = txtName.Text;
            grade.chinese = Convert.ToInt32(txtChinese.Text);
            grade.english = Convert.ToInt32(txtEnglish.Text);
            grade.math = Convert.ToInt32(txtMath.Text);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            labelGrade.Text = "姓名 : " + grade.name + "\n國文 : " + grade.chinese
                + "分\n英文 : " + grade.english + "分\n數學 : " + grade.math + "分";
        }

        private void btnHigh_Click(object sender, EventArgs e)
        {
            
            int min = Min(grade.chinese, grade.english, grade.math);
            int max = Max(grade.chinese, grade.english, grade.math);
            SortedList<string, int> gg= new SortedList<string, int>();
            gg.Add("國文", grade.chinese);
            gg.Add("英文", grade.english);
            gg.Add("數學", grade.math);
            
            labelHigh.Text = "最高科目成績為 : 數學0分\n最低科目成績為 : 數學0分";
            string a = "" , b = "";
            foreach (KeyValuePair<string, int> i in gg)
            {
                if (max == i.Value)
                {
                    a = "最高科目成績為 : " + i.Key + i.Value + "分\n";
                }
            }
            foreach (KeyValuePair<string, int> i in gg)
            {
                if(min == i.Value)
                {
                    b = "最低科目成績為 : " + i.Key + i.Value + "分\n";
                }
            }
            labelHigh.Text = a + b;

        }
    }
}
