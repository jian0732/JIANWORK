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
    public partial class 蝦BB : Form
    {
        public 蝦BB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("恭喜");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserRole KK = UserRole.Admin;
            //if (KK == UserRole.Admin)
            //{
            //    button1.Enabled = true;
            //}
            //    button1.Enabled = false;
            button1.Enabled = KK == UserRole.Admin;
        }
        bool A = true;
        private void button3_Click(object sender, EventArgs e)
        {

            if (A)
            {
                button2.BackColor = Color.Red;
            }
            else
            {
                button2.BackColor = Color.Black;
            }
            //A = !A;
            A = !A;

        }
        int CC = 8;
        private void button4_Click(object sender, EventArgs e)
        {
            button2.BackColor = A ? Color.Red : Color.Black;
            A = !A;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int 分數;
            if(int.TryParse(textBox1.Text, out 分數))
            {
                if (分數 < 100)
                {
                    if (分數 >= 90 && 分數 <= 100)
                        label1.Text = "A級";
                    else if (分數 >= 80)
                        label1.Text = "B級";
                    else if (分數 >= 70)
                        label1.Text = "C級";
                    else if (分數 >= 60)
                        label1.Text = "D級";
                    else if (分數 <= 59)
                        label1.Text = "回去重念";
                }
                else
                    MessageBox.Show("你沒那麼高分");

            }
            else 
            MessageBox.Show("不要亂打");
        }

        private void button6_Click(object sender, EventArgs e)
        {
           DialogResult 是否取消  = MessageBox.Show("今天禮拜三嗎?", "請回答"
                , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch (是否取消)
            {
                case DialogResult.Yes:
                    MessageBox.Show("是禮拜三");
                    break;
                case DialogResult.No:
                    MessageBox.Show("今天不是喔");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("掰掰");
                    break;
            }
               
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i= 0;
            String 存放 = "";
            while (i <= 10)
            {
                存放 +=i+"\n";
                i++;    
            }
            MessageBox.Show(存放);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int i =10;
            String 存放 = "";
            do
            {
                存放 += i + "\n";
                i++;
            } while (i <= 10);
                MessageBox.Show(存放);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String 儲存 = "";
            int P = 0;
            for (int A =1,B=2,C=3,D=4,E=1; E<5; E++)
            {
                儲存 = 儲存 + A + "x" + E +"="+(A * E) +","+B+"x"+E+"="+(B*E)+","+C+"x"+E+"="+(C*E)+"\n";
            

            }
            MessageBox.Show(儲存);
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            int[] A = { 1, 2, 3 };
            int Q = 0;
            for (int i = 0; i < A.Length; i++)
            {
                Q += A[i];
            }
            MessageBox.Show(Q.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[3, 2];
            String 我來接 = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int F=0;i<arr.GetLength(1);F++)
                我來接 = 我來接 + $"arr{i},{F} -> {arr[i,F]}";
            }
            MessageBox.Show(我來接);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int[] intArr = 我是方法(20);
            int QQ=0;
            String IP="";
            //for(int i=0;i<intArr.Length;i++)
            //{
            //   IP+=intArr[i]+"\n";
            //}
            foreach(int item in intArr)
            {
                IP += item + "\n";
            }
            MessageBox.Show(IP);

        }
        int[] 我是方法(int 哭阿)
        {
            int[] arr = new int[哭阿];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            return arr;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Member[] arr = new Member[3];
            String result = "";
            Member[] arrMember =
            {
                new Member(){Name="IU",Age =29},
                new Member(){Name="裡之恩",Age =28}
            };
            //for (int i = 0; i < arrMember.Length; i++)
            //{
            //    result += $"Name:{arrMember[i].Name},年齡:{arrMember[i].Age}\n";
            //}
            foreach(Member item in arrMember)
            {
                result+= $"Name:{item.Name},年齡:{item.Age}\n";
            }
                
                MessageBox.Show(result);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            foreach(Control item in this.Controls)
            {

                if(!(item is Button))
                {
                    continue;
                }
                item.BackColor = Color.Red;
                item.Top -= 10;
                item.Left -= 10;
                item.ForeColor = Color.Green;
            }
        }
    }
}
