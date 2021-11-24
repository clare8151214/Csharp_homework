using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Homepage
{

    public partial class PosForm : Form
    {

        int total_price = 0;
        int[] number = new int[4];
        int[] total = new int[4];
        Dictionary<string, int> menu = new Dictionary<string, int>();
        List<string> show = new List<string>();
        public PosForm()
        {
            InitializeComponent();
        }

        private void PosForm_Load(object sender, EventArgs e)
        {
            menu.Add("Beer", 120);
            menu.Add("Tequila", 180);
            menu.Add("Whisky", 350);
            menu.Add("Wine", 320);
            show.Add("啤酒beer x" + number[0] + ",共NT$ " + total[0] + " 元\n");
            show.Add("龍舌蘭Tequila x" + number[1] + ",共NT$ " + total[1] + " 元\n");
            show.Add("威士忌Whisky x" + number[2] + ",共NT$ " + total[2] + " 元\n");
            show.Add("紅酒Wine x" + number[3] + ",共NT$ " + total[3] + " 元\n");
        }

        private void btnBeer_Click(object sender, EventArgs e)
        {
            total_price += menu["Beer"];
            number[0]++;
            total[0] += menu["Beer"];
            PriceLabel.Text = "NT$ " + total_price;
            show[0] = "啤酒beer x" + number[0] + ",共NT$ " + total[0] + " 元\n";
            list.Text = "";
            for(int i = 0; i < 4; i++)
            {
                if (number[i] != 0)
                    list.Text += show[i];
            }
        }

        private void btnTequila_Click(object sender, EventArgs e)
        {
            total_price += menu["Tequila"];
            number[1] ++;
            total[1] += menu["Tequila"];
            PriceLabel.Text = "NT$ " + total_price;
            show[1] = "龍舌蘭Tequila x" + number[1] + ",共NT$ " + total[1] + " 元\n";
            list.Text = "";
            for (int i = 0; i < 4; i++)
            {
                if (number[i] != 0)
                    list.Text += show[i];
            }
        }

        private void btnWhisky_Click(object sender, EventArgs e)
        {
            total_price += menu["Whisky"];
            number[2] ++;
            total[2] += menu["Whisky"];
            PriceLabel.Text = "NT$ " + total_price;
            show[2] = "威士忌Whisky x" + number[2] + ",共NT$ " + total[2] + " 元\n";
            list.Text = "";
            for (int i = 0; i < 4; i++)
            {
                if (number[i] != 0)
                    list.Text += show[i];
            }
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            total_price += menu["Wine"];
            number[3] ++;
            total[3] += menu["Wine"];
            PriceLabel.Text = "NT$ " + total_price;
            show[3] = "紅酒Wine x" + number[3] + ",共NT$ " + total[3] + " 元\n";
            list.Text = "";
            for (int i = 0; i < 4; i++)
            {
                if (number[i] != 0)
                    list.Text += show[i];
            }
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (total_price == 0)
                MessageBox.Show("尚未點餐!", "確認付款",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            else
                MessageBox.Show("總金額:NT$ " + total_price, "確認付款", MessageBoxButtons.OKCancel);
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            double discount = total_price * 0.9;
            if (total_price == 0)
                MessageBox.Show("尚未點餐!", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("總金額:NT$ " + total_price + "\n折扣後金額:NT$ " + discount,
                            "確認付款", MessageBoxButtons.OKCancel);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            total_price = 0;
            PriceLabel.Text = "NT$ " + total_price;
            for(int i = 0; i < 4; i++)
            {
                number[i] = 0;
                total[i] = 0;
            }
            list.Text = "尚未點餐";
        }



        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
