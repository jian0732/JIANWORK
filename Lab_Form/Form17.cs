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
    public partial class Form1788 : Form
    {
        public Form1788()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member mem1 = new Member();
            mem1.Name = "陳建宏";
            mem1.Age = 18;
            //String name = mem.Name;
            //int age = mem.Age;
            //MessageBox.Show("姓名:"+name+"年齡"+age);
            MessageBox.Show("姓名:"+mem1.Name+",年齡:"+mem1.Age);

            Member mem2 = new Member()
            {
                Name = "李知恩",
                Age = 29
            };
            MessageBox.Show("姓名:"+mem2.Name+",年齡"+mem2.Age);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            //MyClass MC = new MyClass();
            //btnRegister01.Click += new EventHandler(MC.Method04);
            btnRegister01.Click += new EventHandler(bntRegisterClick);
            btnRegister02.Click += BtnRegistr02_Click;
        }

        private void BtnRegistr02_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此按鈕已被激活2");
        }

        private void bntRegisterClick(object sender, EventArgs e)
        {
            MessageBox.Show("此按鈕已被激活1");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            btnRegister01.Click -= bntRegisterClick;
        }


        delegate double Payment(double QQ);
        double Discound50off(double price)
        {
            return price * 0.5;
        }
        double Discound20off(double price)
        {
            return price * 0.8;
        }
        private void btnprice_Click(object sender, EventArgs e)
        {
            Payment pay;
            if (cbBdiscound.Text == "50%")
            {
                pay = Discound50off;
            }
            else
            {
                pay = Discound20off;
            }
            double price = double.Parse(txtBprice.Text);
            double result = pay(price);
            MessageBox.Show(result.ToString());

        }

        private void txtBprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbBdiscound_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        delegate double 委派的名子(double 我不知道這是啥);
        double 價格打幾一折(double 你的金額)
        {
            return 你的金額* 0.9;
        }
        double 價格打幾二折(double 你的金額)
        {
            return 你的金額 * 0.8;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            委派的名子 不知道;
            if(comboBox1.Text == "10%")
            {
                不知道 = 價格打幾一折;
            }
            else
            {
                不知道 = 價格打幾二折;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
           Text = "187";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult Result;
            Result = MessageBox.Show("請問今天禮拜二嗎?", "請問", MessageBoxButtons.YesNoCancel);
            
            if(Result == DialogResult.Yes)
            {
                MessageBox.Show("今天不是禮拜二喔");
            }
            if(Result == DialogResult.No)
            {
                MessageBox.Show("今天是:"+DateTime.Now.DayOfWeek);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double B = 200;
            
            QQ(ref B);
            MessageBox.Show(B.ToString());
        }
        void QQ(ref double A)
        {
            A = 100;
            
        }
        

        private void button8_Click(object sender, EventArgs e)
        {
            Member AP = new Member();
            AP.Name = "媽的";
            AP.Age = 10;
            AVC(AP);
            MessageBox.Show(AP.Name+","+AP.Age);
        }
        void AVC(Member NAME)
        {
            NAME.Age = 20;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int O;
            //O = 200;
            AVC(out O);
            //O = O + 100;
            MessageBox.Show(O.ToString());
        }
        void AVC(out int PP)
        {
            PP = 100;
        }

        private void button10_Click(object sender, EventArgs e)
        {
          String 接住顯示國文總和 =總和方法("國文", 5, 20, 6);
          MessageBox.Show(接住顯示國文總和);
            String 接住顯示數學總和 = 總和方法("數學",10,20);
            MessageBox.Show(接住顯示數學總和);
        }
        String 總和方法(String 科目,params int [] score)
        {
            int Totle = 0;
            for(int i = 0; i < score.Length;i++)
            {
                Totle += score[i];
            }
            return 科目 + "總成績為:" + Totle;
                
        }
        
        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
    
}
