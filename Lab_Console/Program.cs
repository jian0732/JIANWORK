using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Form;


namespace Lab_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO C#!");
            Console.Write("請輸入帥哥姓名:");
            String Name = Console.ReadLine();
            Console.Write("請輸入處男姓名:");
            String QQ = Console.ReadLine();
            Console.WriteLine("帥哥是" + Name);
            Console.WriteLine("可撥的" + QQ);
            MyClass QQQ = new MyClass();
            QQQ.Method05();
            Console.ReadKey();

        
        }
    }
}
