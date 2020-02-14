using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNet_Basic_Day22_16_使用委托进行窗体传值
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 1.注册点击界面1按钮显示界面2的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        ///<![CDATA[2.需求介绍如下:
        ///           弹出窗体2后,在输入框中输入字符串,点击窗体2的按钮,
        ///           将输入的内容显示在窗体1中]]>

        ///<![CDATA[3.解决步骤1:在窗体1中声明显示的方法]]>
        void ShowMsg(string str)
        {
            //将传进的字符串赋值给label显示
            this.label1.Text = str;
        }

        ///<![CDATA[3.问题1:窗体1有方法没有值str,窗体2有值str没有方法
        ///           分析:窗体2拿到窗体1的方法_采用委托即可实现]]>
    }
}
