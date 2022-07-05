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
    public partial class Form7_加減乘除 : Form
    {
        public Form7_加減乘除()
        {
            InitializeComponent();
        }
        double Q = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txbNum1.Text, out Q) && double.TryParse(txbNum2.Text, out Q))


                txbAnswer.Text = (Convert.ToDouble(txbNum1.Text) + Convert.ToDouble(txbNum2.Text)).ToString();
            else
                MessageBox.Show("請輸入數值");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txbNum1.Text, out Q) && double.TryParse(txbNum2.Text, out Q))
                txbAnswer.Text = (Convert.ToDouble(txbNum1.Text) - Convert.ToDouble(txbNum2.Text)).ToString();
            else
                MessageBox.Show("請輸入數值");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txbNum1.Text, out Q) && double.TryParse(txbNum2.Text, out Q))
                txbAnswer.Text = (Convert.ToDouble(txbNum1.Text) * Convert.ToDouble(txbNum2.Text)).ToString();
            else
                MessageBox.Show("請輸入數值");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txbNum1.Text, out Q) && double.TryParse(txbNum2.Text, out Q))
                txbAnswer.Text = (Convert.ToDouble(txbNum1.Text) / Convert.ToDouble(txbNum2.Text)).ToString();
            else
                MessageBox.Show("請輸入數值");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String TT="";

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    TT += $"{j} x {i} ={(i * j).ToString().PadLeft(2,' ')}   ";

                }
                TT += "\n";
            }
            labTT.Text = TT;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

           
            String QQ="";


            for (int i = 0; i < Convert.ToInt32(txbA.Text); i++)
            {
                QQ = QQ + "*";
                for (int j=0; j < i; j++)
                {
                    QQ = QQ + "*";
                    

                }
                QQ = QQ + "\n";
            }
            labTT.Text = QQ;
            }
            catch(Exception)
            {
                MessageBox.Show("輸入數值");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[,] QQ=new int[10,10];
            for(int i=0;i<QQ.Length;i++)
            {

            }
         

        }
    }
}
