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
    public partial class StudentsGrade_List : Form
    {
        List<string> name = new List<string>();
        List<int> chinese = new List<int>();
        List<int> english = new List<int>();
        List<int> math = new List<int>();
        List<int> sum = new List<int>();
        List<double> average = new List<double>();
        List<string> low = new List<string>();
        List<string> high = new List<string>();
        string thelist = "";
        public StudentsGrade_List()
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int n = name.Count;
            if (n >= 0)
            {
                btnRemove.Enabled = true;
                btnAll.Enabled = true;
            }
            if (txtName.Text == "")
                MessageBox.Show("請輸入姓名", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtChinese.Text == "")
                MessageBox.Show("請輸入國文成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtEnglish.Text == "")
                MessageBox.Show("請輸入英文成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtMath.Text == "")
                MessageBox.Show("請輸入數學成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {               
                name.Add(txtName.Text);
                chinese.Add(Convert.ToInt32(txtChinese.Text));
                english.Add(Convert.ToInt32(txtEnglish.Text));
                math.Add(Convert.ToInt32(txtMath.Text));
                sum.Add(chinese[n] + english[n] + math[n]);
                average.Add(Math.Round((chinese[n] + english[n] + math[n]) / 3.0, 1));
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
                        high.Add(i.Key + i.Value);
                    }
                }
                foreach (KeyValuePair<string, int> i in gg)
                {
                    if (min == i.Value)
                    {
                        low.Add(i.Key + i.Value);
                    }
                }
                thelist += String.Format("{0,-6}{1,6}{2,6}{3,6}{4,6}{5,6:N1}{6,6}{7,6}\n"
                      , name[n], chinese[n], english[n], math[n], sum[n], average[n], low[n], high[n]);
                labelGrade.Text = thelist;

                //MessageBox.Show(n.ToString());
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (name.Count >= 0)
            {
                btnRemove.Enabled = true;
                btnAll.Enabled = true;
            }
            if (txtName.Text == "")
                MessageBox.Show("請輸入姓名", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtChinese.Text == "")
                MessageBox.Show("請輸入國文成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtEnglish.Text == "")
                MessageBox.Show("請輸入英文成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtMath.Text == "")
                MessageBox.Show("請輸入數學成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                name.Insert(0,txtName.Text);
                chinese.Insert(0, Convert.ToInt32(txtChinese.Text));
                english.Insert(0, Convert.ToInt32(txtEnglish.Text));
                math.Insert(0, Convert.ToInt32(txtMath.Text));
                sum.Insert(0, chinese[0] + english[0] + math[0]);
                average.Add(Math.Round((chinese[0] + english[0] + math[0]) / 3.0, 1));
                int min = Min(chinese[0], english[0], math[0]);
                int max = Max(chinese[0], english[0], math[0]);
                SortedList<string, int> gg = new SortedList<string, int>();
                gg.Add("國文", chinese[0]);
                gg.Add("英文", english[0]);
                gg.Add("數學", math[0]);
                foreach (KeyValuePair<string, int> i in gg)
                {
                    if (max == i.Value)
                    {
                        high.Insert(0, i.Key + i.Value);
                    }
                }
                foreach (KeyValuePair<string, int> i in gg)
                {
                    if (min == i.Value)
                    {
                        low.Insert(0, i.Key + i.Value);
                    }
                }
                thelist = thelist.Insert(0, String.Format("{0,-6}{1,6}{2,6}{3,6}{4,6}{5,6:N1}{6,6}{7,6}\n"
                     , name[0], chinese[0], english[0], math[0], sum[0], average[0], low[0], high[0]));
                labelGrade.Text = thelist;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            thelist = "";
            if (name.Count < 1)
            {
                btnRemove.Enabled = false;
                btnAll.Enabled = false;
            }
            else
            {
                name.RemoveAt(0);
                chinese.RemoveAt(0);
                english.RemoveAt(0);
                math.RemoveAt(0);
                sum.RemoveAt(0);
                average.RemoveAt(0);
                low.RemoveAt(0);
                high.RemoveAt(0);
            }

            for(int i = 0; i < name.Count; i++)
            {
                thelist += String.Format("{0,-6}{1,6}{2,6}{3,6}{4,6}{5,6:N1}{6,6}{7,6}\n"
                     , name[i], chinese[i], english[i], math[i], sum[i], average[i], low[i], high[i]);
            }
            labelGrade.Text = thelist;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            thelist = "";
            labelAll.Text = "";
            if (name.Count == 0)
                MessageBox.Show("沒東西");
            else
            {
                name.Clear();
                chinese.Clear();
                english.Clear();
                math.Clear();
                sum.Clear();
                average.Clear();
                low.Clear();
                high.Clear();
            }
            labelGrade.Text = thelist;
            btnAdd.Enabled = true;
            btnInsert.Enabled = true;
            btnRemove.Enabled = false;
            btnAll.Enabled = false;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            int minChinese = chinese.Min();
            int minEnglish = english.Min();
            int minMath = math.Min();
            int sumChinese = 0, sumEnglish = 0, sumMath = 0;
            double avgChinese, avgEnglish, avgMath;
            int maxChinese = chinese.Max();
            int maxEnglish = english.Max();
            int maxMath = math.Max();

            for (int i = 0; i < name.Count; i++)
            {
                sumChinese += chinese[i];
                sumEnglish += english[i];
                sumMath += math[i];
            }

            avgChinese = (double)sumChinese / name.Count;
            avgEnglish = (double)sumEnglish / name.Count;
            avgMath = (double)sumMath / name.Count;

            labelAll.Text = String.Format("總分{0,8}{1,6}{2,6}\n"
                , sumChinese, sumEnglish, sumMath);
            labelAll.Text += String.Format("平均{0,8:N1}{1,6:N1}{2,6:N1}\n"
                , avgChinese, avgEnglish, avgMath);
            labelAll.Text += String.Format("最高分{0,6}{1,6}{2,6}\n"
                , maxChinese, maxEnglish, maxMath);
            labelAll.Text += String.Format("最低分{0,6}{1,6}{2,6}\n"
                , minChinese, minEnglish, minMath);

            btnAdd.Enabled = false;
            btnInsert.Enabled = false;
            btnRemove.Enabled = false;
            btnAll.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string temp = "";
            int searchLow = Convert.ToInt32(txtLow.Text);
            int searchHigh = Convert.ToInt32(txtHigh.Text);
            for(int i = searchLow; i <= searchHigh; i++)
            {
                for(int j = 0; j < chinese.Count; j++)
                {
                    if(chinese[j] == i)
                        temp += String.Format("{0,-6}{1,6}{2,6}{3,6}{4,6}{5,6:N1}{6,6}{7,6}\n"
                            , name[j], chinese[j], english[j], math[j], sum[j], average[j], low[j], high[j]);
                }               
            }
            labelGrade.Text = temp;
        }
    }
}
