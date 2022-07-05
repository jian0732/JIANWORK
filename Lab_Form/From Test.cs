using System;
using System.Collections;
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
    public partial class From_Test : Form
    {
        public From_Test()
        {
            InitializeComponent();
        }
        String 串燒;
        String 共;
        int 點擊次數;
        int 總金額;
        private void button1_Click(object sender, EventArgs e)
        {
            點擊次數++;

            //結構1 變數 = new 結構1(textBox1.Text,decimal.Parse(textBox2.Text));       
            //變數.名稱 = textBox1.Text;
            //變數.價格 = decimal.Parse(textBox2.Text);
            decimal QP;
            bool A = decimal.TryParse(textBox2.Text, out QP);
            if(A)
            {
                結構1 變數 = new 結構1(textBox1.Text,QP);
                總金額 += int.Parse(變數.價格.ToString());
                串燒 += "產品:" + 變數.名稱 + ",價格:" + 變數.價格 + "元\n";
                共 = "共" + 點擊次數 + "種產品\n" + "總金額:" + 總金額;
            }
            else
            {
                MessageBox.Show(QP.ToString());
                MessageBox.Show("請輸入數值");
                textBox2.Clear();
                textBox2.Focus();
            }


            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = 串燒+"\n-------------------\n"+共;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void From_Test_Load(object sender, EventArgs e)
        {

        }
        void Swap(ref int A,ref int B)
        {
            int T = A;
            A = B;
            B = T;
        }
        void Swap(ref string A, ref string B)
        {
            string T = A;
            A = B;
            B = T;
        }
        void Generic<QQ>(ref QQ A, ref QQ B)
        {
            QQ T = A;
            A = B;
            B = T;
        }
        void Generic<P, G>(ref P A ,ref G B)
        {
            
            

           

        }
        private void button4_Click(object sender, EventArgs e)
        {
            int A = 100, B = 01100;
            MessageBox.Show($"A={A},B={B}");
            Generic<int>(ref A, ref B);
            MessageBox.Show($"A={A},B={B}");

            String S1 = "AAA", S2 = "BBB";     
            Generic<String>(ref S1, ref S2);
            MessageBox.Show($"A={S1},B={S2}");

            
        }
        ArrayList 資料庫 = new ArrayList();
        private void button5_Click(object sender, EventArgs e)
        {

            結構2 資料;
            資料.名稱 = textBox3.Text;
            資料.年齡 = int.Parse(textBox4.Text);

            資料庫.Add(資料); // 把資料存到ArrayList  資料轉成object
            label6.Text = "員工\n";
            for (int i = 0; i < 資料庫.Count; i++)
            {
                
                label6.Text += "姓名:" +((結構2)資料庫[i]).名稱+",年齡:"+
                   ((結構2)資料庫[i]).年齡 + "\n";
            }
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String QQ="";
            for(int i = 1; i < 10; i++)
            {
                for (int P = 1; P < 10; P++)
                {
                    QQ = QQ + $"{P}x{i} ={i*P}  ";
                }
                QQ = QQ + "\n";
            }
            MessageBox.Show(QQ);
        }


    }
}
