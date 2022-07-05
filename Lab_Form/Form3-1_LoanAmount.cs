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
    public partial class Lab_Form3 : Form
    {
        public Lab_Form3()
        {
            InitializeComponent();
        }

        private void Lab_LoanAmount_Click(object sender, EventArgs e)
        {

        }
        static void MyClass(int Top,int Bot,int Height)
        {
            //int area = (Top + Bot) * Height / 2;
            //String result = ("梯形面積是" + area);
            //Console.WriteLine(result);
        } 
        private void but223_Click(object sender, EventArgs e)
        {
            MyClass Mc = new MyClass();
            Mc.Method02();
            Mc.Method01();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        String BirthYear(int Age)
        {
            int Youryear= DateTime.Now.Year - Age;
            String CHY = "你的出生年是" + Youryear + "年";
            return CHY;
        }
        private void butYear_Click(object sender, EventArgs e)
        {
            //String Old = BirthYear(31);
            //MessageBox.Show(Old);
        }

        private void butpackage_Click(object sender, EventArgs e)
        {
            MyClass package=new MyClass();
            package.Method04();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyClass MC = new MyClass();
            MC.Method05();
        }
        String BBQ(int QQ)
        {
            int QBB = 100 - QQ;
            string QB = "李弘毅還要單身"+QBB+"年";
            return QB;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String QQQB = BBQ(30);
            MessageBox.Show(QQQB);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyClass MC = new MyClass();
            String 最後接收=MC.測試(50);
            MessageBox.Show(最後接收);

        }

        private void Lab_Form3_Load(object sender, EventArgs e)
        {

        }
        public double 每月應付利息;
        private void button1_Click_1(object sender, EventArgs e)
        {
            double 每月應付本息金額之平均攤還率;
            double 頭期款= double.Parse(textBox3.Text);
            double 月利率= (double.Parse(txtByear.Text)/100)/12;
            double 月數 = double.Parse(textBox2.Text)*12;
            double 貸款本金 = double.Parse(txtTop.Text);
            double 貸款減頭期款 = 貸款本金-頭期款;
            
            /*每月應付本息金額之平均攤還率＝{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
              (公式中：月利率 ＝ 年利率／12 ； 月數 = 貸款年限 ｘ 12) 
              平均每月應攤付本息金額＝貸款本金×每月應付本息金額之平均攤還率*/
            每月應付本息金額之平均攤還率 = (Math.Pow((1 + 月利率), 月數) * 月利率) / (Math.Pow((1 + 月利率), 月數) - 1);
            每月應付利息 = Math.Floor(貸款減頭期款 * 每月應付本息金額之平均攤還率);
            MessageBox.Show("月付額:"+每月應付利息+"元");
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            double 每月應付本息金額之平均攤還率;
            double 頭期款 = double.Parse(textBox3.Text);
            double 月利率 = (double.Parse(txtByear.Text) / 100) / 12;
            double 月數 = double.Parse(textBox2.Text) * 12;
            double 貸款本金 = double.Parse(txtTop.Text);
            double 貸款減頭期款 = 貸款本金 - 頭期款;

            /*每月應付本息金額之平均攤還率＝{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
              (公式中：月利率 ＝ 年利率／12 ； 月數 = 貸款年限 ｘ 12) 
              平均每月應攤付本息金額＝貸款本金×每月應付本息金額之平均攤還率*/
            每月應付本息金額之平均攤還率 = (Math.Pow((1 + 月利率), 月數) * 月利率) / (Math.Pow((1 + 月利率), 月數) - 1);
            每月應付利息 = Math.Floor(貸款減頭期款 * 每月應付本息金額之平均攤還率);
            
            MessageBox.Show("總付款:"+(每月應付利息* (double.Parse(textBox2.Text)*12)).ToString()+"元");
            
        }
        
        public void button5_Click(object sender, EventArgs e)
        {
            Lab_LoanAmount_1 Report = new Lab_LoanAmount_1();
            Report.label3.Text= txtTop.Text;
            Report.label5.Text = textBox2.Text;
            Report.label6.Text = txtByear.Text;
            Report.label7.Text = 每月應付利息.ToString();
            Report.label8.Text = (每月應付利息 * (double.Parse(textBox2.Text) * 12)).ToString();
            Report.Show();
            
            

        }
    }
}
