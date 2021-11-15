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
    public partial class Method : Form
    {

        int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        string[] arr0711_Str = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
        int[,] t2d = new int[10, 10];
        public Method()
        {
            InitializeComponent();
        }

        private void btnOE_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "")
                MessageBox.Show("請輸入數值");
            else
            {
                int n = Convert.ToInt32(txtNumber.Text);
                if (n % 2 == 0)
                    labelResult.Text = "輸入的數 " + n + "為 偶數";
                else
                    labelResult.Text = "輸入的數 " + n + "為 奇數";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelResult.Text = "結果";
        }

        private void btnMax_Min_Click(object sender, EventArgs e)
        {
            labelResult.Text = "int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n" +
                "最大值為 " + arr0711.Max() + "\n最小值為 " + arr0711.Min();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int odd = 0;
            int even = 0;
            foreach(int i in arr0711)
            {
                if (i % 2 == 0)
                    even++;
                else
                    odd++;
            }
            labelResult.Text = "int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n" +
                "奇數共 " + odd + "\n偶數共 " + even;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            labelResult.Text = "int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n" +
                "加總為 " + arr0711.Sum();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            labelResult.Text = "int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n" +
                "最大值為 " + arr0711.Max();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            labelResult.Text = "int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n" +
                "最小值為 " + arr0711.Min();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;

            labelResult.Text = "arr0711_Str陣列 :   ";
            for(int i = 0; i < arr0711_Str.Length; i++)
            {
                labelResult.Text += "   " + arr0711_Str[i];
                if (arr0711_Str[i].IndexOf('C') != -1 || arr0711_Str[i].IndexOf('c') != -1)
                    c++;
            }
            labelResult.Text += "\n有C 及 c的名字共有 " + c + " 個";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int max = arr0711_Str[0].Length;
            int j = 0;
            labelResult.Text = "arr0711_Str陣列[" + arr0711_Str[0];
            for (int i = 1; i < arr0711_Str.Length; i++)
            {
                labelResult.Text += "," + arr0711_Str[i];
                if (arr0711_Str[i].Length > max)
                {
                    max = arr0711_Str[i].Length;
                    j = i;
                }
            }
            labelResult.Text += "]\n最長的名字為" + arr0711_Str[j];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";
            for(int i = 0; i < t2d.GetUpperBound(0); i++)
            {
                if(i == 0 || i == t2d.GetUpperBound(0) - 1)
                {
                    for(int j = 0; j < t2d.GetUpperBound(1); j++)
                    {
                        t2d[i,j] = 1;
                        labelResult.Text += " " + t2d[i, j]; 
                    }
                }
                else
                {
                    t2d[i, 0] = 1;
                    labelResult.Text += " " + t2d[i, 0];
                    for (int j = 1; j < t2d.GetUpperBound(1) - 1; j++)
                    {
                        t2d[i, j] = 0;
                        labelResult.Text += " " + t2d[i, j];
                    }
                    t2d[i, 9] = 1;
                    labelResult.Text += " " + t2d[i, 9];
                }
                labelResult.Text += " \n";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";
            for (int i = 0; i < t2d.GetUpperBound(0); i++)
            {
                if (i == 0 || i == t2d.GetUpperBound(0) - 1)
                {
                    for (int j = 0; j < t2d.GetUpperBound(1); j++)
                    {
                        t2d[i, j] = 0;
                        labelResult.Text += " " + t2d[i, j];
                    }
                }
                else
                {
                    t2d[i, 0] = 0;
                    labelResult.Text += " " + t2d[i, 0];
                    for (int j = 1; j < t2d.GetUpperBound(1) - 1; j++)
                    {
                        t2d[i, j] = 1;
                        labelResult.Text += " " + t2d[i, j];
                    }
                    t2d[i, 9] = 0;
                    labelResult.Text += " " + t2d[i, 9];
                }
                labelResult.Text += " \n";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";
            for (int i = 0; i < t2d.GetUpperBound(0); i++)
            {
                if (i%2 == 0)
                {
                    for (int j = 0; j < t2d.GetUpperBound(1); j++)
                    {
                        if(j%2 == 0)
                            t2d[i, j] = 1;
                        else
                            t2d[i, j] = 0;
                        labelResult.Text += " " + t2d[i, j];
                    }
                }
                else
                {
                    for (int j = 0; j < t2d.GetUpperBound(1); j++)
                    {
                        if (j % 2 == 0)
                            t2d[i, j] = 0;
                        else
                            t2d[i, j] = 1;
                        labelResult.Text += " " + t2d[i, j];
                    }
                }
                labelResult.Text += " \n";
            }
        }
        public static void Swap(ref int a,ref int b)
        {
            a ^= b; //XOR
            b ^= a;
            a ^= b;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            int n1 = 100, n2 = 200;
            labelResult.Text = "換位前n1 = " + n1 + " , n2 = " + n2 + "\n";
            Swap(ref n1, ref n2);
            labelResult.Text += "換位後n1 = " + n1 + " , n2 = " + n2 + "\n";
        }
    }
}
