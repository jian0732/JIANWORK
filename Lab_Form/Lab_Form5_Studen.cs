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
    public partial class Lab_Form5_Studen : Form
    {
        public Lab_Form5_Studen()
        {
            InitializeComponent();
        }
        String 姓名; 
        int 國文分數, 英文分數, 數學分數;
        private void button3_Click(object sender, EventArgs e)
        {
            ///Dictionary<String, int> 資料 = new Dictionary<string, int>();
            ///資料.Add("國文",國文分數);
            ///資料.Add("英文",英文分數);
            ///資料.Add("數學",數學分數);
            ///var a = 資料.AsEnumerable().OrderByDescending(x => x.Value).ToList();
            ///lab2.Text = $"最高分科成績為:{ a[0].Key + a[0].Value}分\n最低分科目成績為{a[a.Count - 1].Key + a[a.Count - 1].Value }分";
            //int[] 最小分數陣列 = { 國文分數, 英文分數, 數學分數 };
            //String[] 最小科目陣列 = { "國文", "英文", " 數學" };
            //int 最大分數 = 分數陣列[0];
            //String 對應科目=科目陣列[0];
            //int 最小分數=最小分數陣列[0];
            //String 最小科目=最小科目陣列[0];
            //for (int i = 0; i < 分數陣列.Length; i++)
            //{
            //    if (分數陣列[i] > 最大分數)
            //    {
            //        最大分數 = 分數陣列[i];
            //        對應科目 = 科目陣列[i];
            //    }
            //    if (最小分數陣列[i] < 最小分數)
            //    {
            //        最小分數 = 最小分數陣列[i];
            //        最小科目 = 最小科目陣列[i];
            //    }
            //}
            //lab2.Text = "最高成績科目:" + 對應科目 + ":" + 最大分數 + "\n" +
            //    "最低成績科目:" + 最小科目 + 最小分數;
            int[] 分數陣列 = { 國文分數, 英文分數, 數學分數 };
            String[] 科目陣列 = { "國文", "英文", " 數學" };

            //(比較的陣列,跟著前面走)
            Array.Sort(分數陣列, 科目陣列);
            Array.Reverse(分數陣列); Array.Reverse(科目陣列);//反轉
            lab2.Text = "最高分科目成績為:" + 科目陣列[2] + 科目陣列[2] + "\n最低分科目成績為" + 科目陣列[0] + 分數陣列[0];












        }

        private void Lab_Form5_Studen_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lab1.Text =$"姓名:{姓名}\n國文:{國文分數}分\n英文:{英文分數}分\n數學:{數學分數}分";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            姓名 = txtBName.Text;
            國文分數 = int.Parse(txtBChinese.Text);
            英文分數 = int.Parse(txtBEnglish.Text);
            數學分數 = int.Parse(txtBmath.Text);
        }

    }
}
