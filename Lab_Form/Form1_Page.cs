using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Lab_Form
{
    public partial class Form1_Page : Form
    {
        public Form1_Page()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Lab_Form2 P1 = new Lab_Form2();
            P1.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(P1);           
            P1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Lab_Form3 P2 = new Lab_Form3();
            P2.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(P2);
            P2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Lab_Form4_Pos P3 = new Lab_Form4_Pos();
            P3.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(P3);
            P3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Lab_Form5_Studen P4 = new Lab_Form5_Studen();
            P4.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(P4);
            P4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Form1 P5 = new Form1();
            P5.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(P5);
            P5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Form7_加減乘除 P6 = new Form7_加減乘除();
            P6.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(P6);
            P6.Show();
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Form_圈圈叉叉 P7 = new Form_圈圈叉叉();
            P7.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(P7);
            P7.Show();

        }
    }
}
