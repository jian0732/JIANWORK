using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
   public partial class MyClass
    {
        
        internal void Method01()
        {
            MessageBox.Show("Method internal");
        }
        public void Method02()
        {
            MessageBox.Show("Method public");
        }
        void Method03()
        {
            MessageBox.Show("Method03");
        }
        public void Method04()
        {
            Method01();
            Method03();
        }
        public String 測試(int 年齡)
        {
            int 你的西元年=DateTime.Now.Year - 年齡;
            String 文字 = "你的西元年是" + 你的西元年 + "年";
            return 文字;
        }

    }
}
