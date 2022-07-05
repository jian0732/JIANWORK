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
    public partial class Form_圈圈叉叉 : Form
    {
        public Form_圈圈叉叉()
        {
            InitializeComponent();
        }
        bool DD = true;

        void 清除()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;


        }
        DialogResult qq;
        void 方法哥()
        {
            
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")  qq = MessageBox.Show("X贏了","完局!",MessageBoxButtons.OK);
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")  qq = MessageBox.Show("X贏了", "完局!", MessageBoxButtons.OK);
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")  qq = MessageBox.Show("X贏了", "完局!", MessageBoxButtons.OK);
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")  qq = MessageBox.Show("X贏了", "完局!", MessageBoxButtons.OK);
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")  qq = MessageBox.Show("X贏了", "完局!", MessageBoxButtons.OK);
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")  qq = MessageBox.Show("X贏了", "完局!", MessageBoxButtons.OK);
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")  qq = MessageBox.Show("X贏了", "完局!", MessageBoxButtons.OK);
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")  qq = MessageBox.Show("X贏了", "完局!", MessageBoxButtons.OK);

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O") qq = MessageBox.Show("O贏了", "完局!", MessageBoxButtons.OK);
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") qq = MessageBox.Show("O贏了", "完局!", MessageBoxButtons.OK);
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") qq = MessageBox.Show("O贏了", "完局!", MessageBoxButtons.OK);
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") qq = MessageBox.Show("O贏了", "完局!", MessageBoxButtons.OK);
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") qq = MessageBox.Show("O贏了", "完局!", MessageBoxButtons.OK);
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") qq = MessageBox.Show("O贏了", "完局!", MessageBoxButtons.OK);
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O") qq = MessageBox.Show("O贏了", "完局!", MessageBoxButtons.OK);
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O") qq = MessageBox.Show("O贏了", "完局!", MessageBoxButtons.OK);
            if (qq == DialogResult.OK)
            { 
                清除();
                qq = DialogResult.None;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(DD == true)
            {
                button1.Text = "X";
                DD = false;
            }
            else
            {
                button1.Text = "O";
                DD = true;
            }
            button1.Enabled = false;
            方法哥();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DD == true)
            {
                button2.Text = "X";
                DD = false;
            }
            else
            {
                button2.Text = "O";
                DD = true;
            }
            button2.Enabled = false;
            方法哥();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DD == true)
            {
                button3.Text = "X";
                DD = false;
            }
            else
            {
                button3.Text = "O";
                DD = true;
            }
            button3.Enabled = false;
            方法哥();
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (DD == true)
            {
                button4.Text = "X";
                DD = false;
            }
            else
            {
                button4.Text = "O";
                DD = true;
            }
            button4.Enabled = false;
            方法哥();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (DD == true)
            {
                button5.Text = "X";
                DD = false;
            }
            else
            {
                button5.Text = "O";
                DD = true;
            }
            button5.Enabled = false;
            方法哥();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (DD == true)
            {
                button6.Text = "X";
                DD = false;
            }
            else
            {
                button6.Text = "O";
                DD = true;
            }
            button6.Enabled = false;
            方法哥();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (DD == true)
            {
                button7.Text = "X";
                DD = false;
            }
            else
            {
                button7.Text = "O";
                DD = true;
            }
            button7.Enabled = false;
            方法哥();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (DD == true)
            {
                button8.Text = "X";
                DD = false;
            }
            else
            {
                button8.Text = "O";
                DD = true;
            }
            button8.Enabled = false;
            方法哥();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (DD == true)
            {
                button9.Text = "X";
                DD = false;
            }
            else
            {
                button9.Text = "O";
                DD = true;
            }
            button9.Enabled = false;
            方法哥();
            

        }

        private void button10_Click(object sender, EventArgs e)
        {
            清除();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
