using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
   partial class MyClass
    {
        public void Method05()
        {
            MessageBox.Show("Method partial Class");
        }
    }

   public class Member
    {
        public String Name;
        public int Age;
    }
    public enum UserRole
    {
        Admin ,
        User =2,
    }
    public struct 結構1
    {
        public String 名稱;
        public decimal 價格;

        public 結構1(String Name,decimal PP)
        {
            名稱 = Name;
            價格 = PP;
        }
    }
    public struct 結構2
    {
        public String 名稱;
        public decimal 年齡;

    }
}
