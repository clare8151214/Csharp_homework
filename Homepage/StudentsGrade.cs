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
    public partial class StudentsGrade : Form
    {
        string[] name = new string[101];
        int[] chinese = new int[101];
        int[] english = new int[101];
        int[] math = new int[101];
        double[] average = new double[101];
        int[] sum = new int[101];
        string[] low = new string[101];
        string[] high = new string[101];
        public StudentsGrade()
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
        int n = -1;
        private void btnAdd_Click(object sender, EventArgs e)
        {   
            if (n > 99)
            {
                MessageBox.Show("記憶體空間已滿，請先刪除舊有資料", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAdd.Enabled = false;
            }
            n++;
            if (n > -1)
                btnAll.Enabled = true;
            if (txtName.Text == "")
                MessageBox.Show("請輸入姓名","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            else if(txtChinese.Text == "")
                MessageBox.Show("請輸入國文成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtEnglish.Text == "")
                MessageBox.Show("請輸入英文成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(txtMath.Text == "")
                MessageBox.Show("請輸入數學成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                name[n] = txtName.Text;
                chinese[n] = Convert.ToInt32(txtChinese.Text);
                english[n] = Convert.ToInt32(txtEnglish.Text);
                math[n] = Convert.ToInt32(txtMath.Text);
                sum[n] = chinese[n] + english[n] + math[n];
                average[n] = Math.Round((chinese[n] + english[n] + math[n]) / 3.0, 1);
                int min = Min(chinese[n], english[n], math[n]);
                int max = Max(chinese[n], english[n], math[n]);
                SortedList<string, int> gg = new SortedList<string, int>();
                gg.Add("國文", chinese[n]);
                gg.Add("英文", english[n]);
                gg.Add("數學", math[n]);
                foreach (KeyValuePair<string, int> i in gg)
                {
                    if (max == i.Value)
                    {
                        high[n] = i.Key + i.Value;
                    }
                }
                foreach (KeyValuePair<string, int> i in gg)
                {
                    if (min == i.Value)
                    {
                        low[n] = i.Key + i.Value;
                    }
                }
                labelGrade.Text += String.Format("{0,-6}{1,6}{2,6}{3,6}{4,6}{5,6:N1}{6,6}{7,6}\n"
                      , name[n], chinese[n], english[n], math[n], sum[n], average[n], low[n], high[n]);
            }
            
            
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (n == -1)
                n++;
            if (n > 99)
            {
                MessageBox.Show("記憶體空間已滿，請先刪除舊有資料", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAdd.Enabled = false;
            }
            else
            {
                Random random = new Random();
                name[n] = (n + 1).ToString();
                chinese[n] = random.Next(101);
                english[n] = random.Next(101);
                math[n] = random.Next(101);
                sum[n] = chinese[n] + english[n] + math[n];
                average[n] = Math.Round((chinese[n] + english[n] + math[n]) / 3.0, 1);
                int min = Min(chinese[n], english[n], math[n]);
                int max = Max(chinese[n], english[n], math[n]);
                SortedList<string, int> gg = new SortedList<string, int>();
                gg.Add("國文", chinese[n]);
                gg.Add("英文", english[n]);
                gg.Add("數學", math[n]);
                foreach (KeyValuePair<string, int> i in gg)
                {
                    if (max == i.Value)
                    {
                        high[n] = i.Key + i.Value;
                    }
                }
                foreach (KeyValuePair<string, int> i in gg)
                {
                    if (min == i.Value)
                    {
                        low[n] = i.Key + i.Value;
                    }
                }
                labelGrade.Text += String.Format("{0,-6}{1,6}{2,6}{3,6}{4,6}{5,6:N1}{6,6}{7,6}\n"
                      , name[n], chinese[n], english[n], math[n], sum[n], average[n], low[n], high[n]);
                n++;
            }
            if (n > -1)
                btnAll.Enabled = true;

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            int minChinese = chinese[0];
            int minEnglish = english[0];
            int minMath = math[0];
            for(int i = 1; i < n; i++) //由於我寫的Min方法不適合Array因為會判斷為0所以另寫迴圈
            {
                if (minChinese > chinese[i])
                    minChinese = chinese[i];
                if (minEnglish > english[i])
                    minEnglish = english[i];
                if (minMath > math[i])
                    minMath = math[i];
            }

            int sumChinese = 0, sumEnglish = 0, sumMath = 0;
            double avgChinese, avgEnglish, avgMath;
            int maxChinese = Max(chinese);
            int maxEnglish = Max(english);
            int maxMath = Max(math);
            
            for (int i = 0; i < n; i++)
            {
                sumChinese += chinese[i];
                sumEnglish += english[i];
                sumMath += math[i];
            }

            avgChinese = (double)sumChinese / n;
            avgEnglish = (double)sumEnglish / n;
            avgMath = (double)sumMath / n;

            labelAll.Text = String.Format("總分{0,8}{1,6}{2,6}\n"
                ,sumChinese,sumEnglish,sumMath);
            labelAll.Text += String.Format("平均{0,8:N1}{1,6:N1}{2,6:N1}\n"
                , avgChinese,avgEnglish,avgMath);
            labelAll.Text += String.Format("最高分{0,6}{1,6}{2,6}\n"
                , maxChinese, maxEnglish, maxMath);
            labelAll.Text += String.Format("最低分{0,6}{1,6}{2,6}\n"
                , minChinese, minEnglish, minMath);

            btnAdd.Enabled = false;
            btnRandom.Enabled = false;
            btnRandom20.Enabled = false;
            btnAll.Enabled = false;
        }

        private void btnRandom20_Click(object sender, EventArgs e)
        {
            if (n == -1)
                n++;
            if (n > 99)
            {
                MessageBox.Show("記憶體空間已滿，請先刪除舊有資料", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAdd.Enabled = false;
            }
            else
            {
                int k = 20;
                Random random = new Random();
                while (k > 0)
                {
                    name[n] = (n + 1).ToString();
                    chinese[n] = random.Next(101);
                    english[n] = random.Next(101);
                    math[n] = random.Next(101);
                    sum[n] = chinese[n] + english[n] + math[n];
                    average[n] = Math.Round((chinese[n] + english[n] + math[n]) / 3.0, 1);
                    int min = Min(chinese[n], english[n], math[n]);
                    int max = Max(chinese[n], english[n], math[n]);
                    SortedList<string, int> gg = new SortedList<string, int>();
                    gg.Add("國文", chinese[n]);
                    gg.Add("英文", english[n]);
                    gg.Add("數學", math[n]);
                    foreach (KeyValuePair<string, int> i in gg)
                    {
                        if (max == i.Value)
                        {
                            high[n] = i.Key + i.Value;
                        }
                    }
                    foreach (KeyValuePair<string, int> i in gg)
                    {
                        if (min == i.Value)
                        {
                            low[n] = i.Key + i.Value;
                        }
                    }
                    labelGrade.Text += String.Format("{0,-6}{1,6}{2,6}{3,6}{4,6}{5,6:N1}{6,6}{7,6}\n"
                          , name[n], chinese[n], english[n], math[n], sum[n], average[n], low[n], high[n]);

                    n++;
                    k--;
                }
            }
            if (n > -1)
                btnAll.Enabled = true;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Array.Clear(name, 0, n);
            Array.Clear(chinese, 0, n);
            Array.Clear(english, 0, n);
            Array.Clear(math, 0, n);
            Array.Clear(sum, 0, n);
            Array.Clear(average, 0, n);
            Array.Clear(low, 0, n);
            Array.Clear(high, 0, n);
            n = -1;
            labelGrade.Text = "";
            labelAll.Text = "";
            btnAdd.Enabled = true;
            btnRandom.Enabled = true;
            btnRandom20.Enabled = true;
            btnAll.Enabled = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
