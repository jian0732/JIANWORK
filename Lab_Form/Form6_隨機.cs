using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            
            InitializeComponent();
            
        }

        List<yee> yees = new List<yee>();
        List<double> YO = new List<double>();
        List<double> YY = new List<double>();
        List<double> UU = new List<double>();

        yee emp;
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            int QQ = 0;
            if (int.TryParse(textBox2.Text, out QQ) && int.TryParse(textBox3.Text, out QQ)&& int.TryParse(textBox4.Text, out QQ))
            {
                listView1.Items.Clear();
                方法(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
                
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }
        void 方法(string 姓名, double 國分, double 數分, double 英分)
        {                                
            emp.姓名 = 姓名;
            emp.國分 = 國分;
            emp.數分 = 數分;
            emp.英分 = 英分;
            yees.Add(emp);
           
            foreach (yee emp in yees)
            {
                double[] 分數 = { emp.國分, emp.數分, emp.英分 };
                string[] 科目 = { "國文", "數學", "英文" };
                Array.Sort(分數, 科目);
                int i = 0;
                YO.Add(emp.國分);
                YY.Add(emp.數分);
                UU.Add(emp.英分);
                i = listView1.Items.Count + i;

                listView1.Items.Add(emp.姓名);
                listView1.Items[i].SubItems.Add(emp.國分.ToString());
                listView1.Items[i].SubItems.Add(emp.數分.ToString());
                listView1.Items[i].SubItems.Add(emp.英分.ToString());
                listView1.Items[i].SubItems.Add((emp.國分 + emp.數分 + emp.英分).ToString());
                listView1.Items[i].SubItems.Add(Math.Round(emp.國分 + emp.數分 + emp.英分 / 3,1).ToString());
                listView1.Items[i].SubItems.Add(科目[0] + 分數[0]);
                listView1.Items[i].SubItems.Add(科目[2] + 分數[2]);
            }
            button2.Enabled = true;
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string rr = "0";
            string QQ = "0";
            string PP = "0";
            for (int P = 0; P < listView1.Items.Count; P++)
            {
                rr =(Convert.ToInt32(rr) +Convert.ToInt32(listView1.Items[P].SubItems[1].Text)).ToString();
                QQ = (Convert.ToInt32(QQ) + Convert.ToInt32(listView1.Items[P].SubItems[2].Text)).ToString();
                PP = (Convert.ToInt32(PP) + Convert.ToInt32(listView1.Items[P].SubItems[3].Text)).ToString();
            }
            listView2.Items.Add("總分");
            listView2.Items[0].SubItems.Add(rr);
            listView2.Items[0].SubItems.Add(QQ);
            listView2.Items[0].SubItems.Add(PP);
            listView2.Items.Add("平均");
            listView2.Items[1].SubItems.Add(Math.Round(Convert.ToDouble(rr)  / listView1.Items.Count, 1).ToString());
            listView2.Items[1].SubItems.Add(Math.Round(Convert.ToDouble(QQ) / listView1.Items.Count, 1).ToString());
            listView2.Items[1].SubItems.Add(Math.Round(Convert.ToDouble(PP) / listView1.Items.Count, 1).ToString());
            listView2.Items.Add("最高分");
            listView2.Items[2].SubItems.Add(YO.Max().ToString());
            listView2.Items[2].SubItems.Add(YY.Max().ToString());
            listView2.Items[2].SubItems.Add(UU.Max().ToString());
            listView2.Items.Add("最低分");
            listView2.Items[3].SubItems.Add(YO.Min().ToString());
            listView2.Items[3].SubItems.Add(YY.Min().ToString());
            listView2.Items[3].SubItems.Add(UU.Min().ToString());
            
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;

        }
        Random 隨機 = new Random();

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 1;
            String 姓名;
            int 國文隨機 = 隨機.Next(0, 100);
            int 數學隨機 = 隨機.Next(0, 100);
            int 英文隨機 = 隨機.Next(0, 100);

            姓名 =(listView1.Items.Count + i).ToString();
            listView1.Items.Clear();
            方法(姓名, 國文隨機, 數學隨機, 英文隨機);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            for (int P = 0; P < 20; P++)
            {
                int i = 1;
                String 姓名;
                int 國文隨機 = 隨機.Next(0, 100);
                int 數學隨機 = 隨機.Next(0, 100);
                int 英文隨機 = 隨機.Next(0, 100);

                姓名 = (listView1.Items.Count + i).ToString();
                listView1.Items.Clear();
                方法(姓名, 國文隨機, 數學隨機, 英文隨機);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            yees.Clear();
            YO.Clear();
            YY.Clear();
            UU.Clear();
            listView1.Items.Clear();
            listView2.Items.Clear();
            button1.Enabled = true;
            button3.Enabled = true;
            button5.Enabled = true;
        }      
    }
}
