using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Lab_Form4_Pos : Form
    {
        public Lab_Form4_Pos()
        {
            InitializeComponent();
        }
        double Totle;
        int 啤酒點擊次數,龍舌蘭點擊次數,威士忌點擊次數,紅酒點擊次數;//點幾次數
        int 啤酒金額 =120,龍舌蘭金額 =180 ,威士忌金額=350 ,紅酒金額=320  ;
        String 啤酒字串,龍舌蘭字串,威士忌字串,紅酒字串;

        private void button1_Click(object sender, EventArgs e)
        {
            啤酒點擊次數++;
            Totle += 啤酒金額;
            txBTotle.Text = "NT$"+Totle.ToString();
            啤酒字串 = "啤酒 Beer x" + 啤酒點擊次數 + ",共NT$" + 啤酒金額 * 啤酒點擊次數 + "元\n";
            labList.Text = 啤酒字串+龍舌蘭字串+威士忌字串+紅酒字串;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           龍舌蘭點擊次數 ++;
           Totle += 龍舌蘭金額;
           txBTotle.Text = "NT$"+Totle.ToString();
           龍舌蘭字串 = "龍舌蘭Tequila x" + 龍舌蘭點擊次數 + ",共NT$" + 龍舌蘭金額 *龍舌蘭點擊次數  + "元\n";
           labList.Text = 啤酒字串 + 龍舌蘭字串 + 威士忌字串 + 紅酒字串;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            威士忌點擊次數++;
            Totle += 威士忌金額;
            txBTotle.Text = "NT$" + Totle.ToString();
            威士忌字串 = "威士忌 Whysky x" + 威士忌點擊次數 + ",共NT$" + 威士忌金額 * 威士忌點擊次數 + "元\n";            
            labList.Text = 啤酒字串 + 龍舌蘭字串 + 威士忌字串 + 紅酒字串;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            紅酒點擊次數++;
            Totle += 紅酒金額;
            txBTotle.Text = "NT$" + Totle.ToString();
            紅酒字串 = "紅酒 Wine x" + 紅酒點擊次數 + ",共NT$" + 紅酒金額 * 紅酒點擊次數 + "元\n";
            labList.Text = 啤酒字串 + 龍舌蘭字串 + 威士忌字串 + 紅酒字串;
        }

        private void txBTotle_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Totle.ToString(),"確認付款",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        
            if(txBTotle.Text == "NT$0")
            {
                MessageBox.Show("尚未點餐", "確認付款", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("總金額:"+Totle.ToString()+"\n"+"折扣後金額:"+Totle*0.9,"確認付款",MessageBoxButtons.OKCancel);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txBTotle.Text == "NT$0")
            {
                MessageBox.Show("尚未點餐", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("總金額:" + Totle.ToString(), "確認付款", MessageBoxButtons.OKCancel);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            啤酒字串 = ""; 龍舌蘭字串 = ""; 威士忌字串=""; 紅酒字串 = " ";
            Totle = 0;
            啤酒點擊次數 = 0; 龍舌蘭點擊次數 = 0; 威士忌點擊次數 = 0; 紅酒點擊次數 = 0;
            txBTotle.Text = "NT$0";
            labList.Text = "尚未點餐";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
