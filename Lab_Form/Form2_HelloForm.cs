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
    public partial class Lab_Form2 : Form
    {
        public Lab_Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butgo_Click(object sender, EventArgs e)
        {
            String CHname = txtCHname.Text;
            String ENGname = txtENGname.Text;
            String Gender = txtgender.Text;
            String CSLT = txtcslt.Text;
            MessageBox.Show("哈喽,我是"+CHname+",\n"
                            +"我的英文名子是"+ENGname+"\n"
                            +"性別是"+Gender + ",\n"
                            + "星座是"+CSLT + ",\n"
                            + "很高興認識你。");
        }

        private void labID_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void butCHhI_MouseMove(object sender, MouseEventArgs e)
        {
            butCHhI.BackColor = Color.LightSlateGray;
        }

        private void butCHhI_MouseLeave(object sender, EventArgs e)
        {
            butCHhI.BackColor = Color.MintCream;
        }

        private void butENGhi_Click(object sender, EventArgs e)
        {
            String CHname = txtCHname.Text;
            String ENGname = txtENGname.Text;
            String Gender = txtgender.Text;
            String CSLT = txtcslt.Text;
            MessageBox.Show("HI,我是" + CHname + ",\n"
                            + "我的英文名子是" + ENGname + "\n"
                            + "性別是" + Gender + ",\n"
                            + "星座是" + CSLT + ",\n"
                            + "很高興認識你。");
        }

        private void butENGhi_MouseMove(object sender, MouseEventArgs e)
        {
            butENGhi.BackColor = Color.LightSlateGray;
        }

        private void butENGhi_MouseLeave(object sender, EventArgs e)
        {
            butENGhi.BackColor = Color.MintCream;
        }

        private void Lab_Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
