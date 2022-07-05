using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class FrmQQ : Form
    {
        public FrmQQ()
        {
            InitializeComponent();
        }
        void QQ()
        {
            label6.Text = "員工\n";
            foreach (結構2 item in 資料庫)
            {
                label6.Text += "姓名:" + item.名稱 + ",年齡:" +item.年齡 + "\n";
            }
            label6.Text += "------------\n員工數量:" + 資料庫.Count;
        }
        List<結構2> 資料庫 = new List<結構2>();

        private void button5_Click(object sender, EventArgs e)
        {
            結構2 資料;
            資料.名稱 = textBox3.Text;
            資料.年齡 = int.Parse(textBox4.Text);
            資料庫.Add(資料);
            QQ();

            //for (int i = 0; i < 資料庫.Count; i++)
            //{

            //    label6.Text += "姓名:" +資料庫[i].名稱 + ",年齡:" +
            //       資料庫[i].年齡 + "\n";
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            資料庫.Clear();
            QQ();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder SB1 = new StringBuilder();
            SB1.Append("傻B1");
            StringBuilder SB2 = new StringBuilder();
            SB2 = SB1;
            SB2.Append("\n傻B2");
            MessageBox.Show(SB1.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string 路徑 = @"C:\Users\Student\Desktop\圖片\尼哥.jpg";
            string result = "";
            result += Path.GetDirectoryName(路徑)+"\n"+
                Path.GetExtension(路徑) + "\n"+
                Path.GetFileName(路徑);
            MessageBox.Show(result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = 驗證密碼(textBox1.Text) ? "密碼強度高" : "密碼強度過低";
            label2.Text = 驗證身分證(textBox2.Text) ? "格式正確" : "請輸入正確格式";
        }

        bool 驗證密碼(string 密碼)
        {
            return Regex.IsMatch(密碼, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]),{8,16}$");
        }
        bool 驗證身分證(string 身分證)
        {
            return Regex.IsMatch(身分證, @"^[A-Z]{1}[1-2]{1}[09]{8}$");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String 喔 = "給他一張自願留營表";
            char C = 喔[5];
            string SS = 喔.Substring(4);
            string result = "";

            //for (int i = 0; i < 喔.Length; i++)
            //{
            //    result += 喔[i] + "\n";
            //}
            foreach(char item in 喔)
            {
                result += item + "\n";
            }
            MessageBox.Show(result);
            MessageBox.Show(SS);
        }
        bool flag = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag) 
            {
                label1.BackColor = Color.Red;
                label1.ForeColor = Color.Crimson;
            }
            else
            {
                label1.BackColor = Color.Gainsboro;
                label1.ForeColor = Color.LightSkyBlue;
            }
            flag = !flag;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StreamReader SS = new StreamReader(@"C:\Users\Student\Desktop\爛.txt", Encoding.UTF8);
            textBox5.Text = SS.ReadToEnd();
            SS.Close();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            FileStream FF = new FileStream(@"C:\Users\Student\Desktop\QQQ.txt",FileMode.Create);
            StreamWriter ss = new StreamWriter(FF,Encoding.Default);
            ss.Write(textBox5.Text);
            ss.Close();
            FF.Close();
        }
    }
}
