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
    ///<![CDATA[4.窗体2中声明一个委托]]>
    //委托必须和窗体1中的方法有相同的签名
    public delegate void DelShowMsg(string str);
    public partial class Form2 : Form
    {
        ///<![CDATA[6.窗体2中声明一个委托类型的字段,将方法通过参数传进Form2的构造函数中]]>
        public DelShowMsg _delShowMsg;
        ///<![CDATA[7.在Form2的构造函数中传入委托参数变成有参构造函数,并赋值给委托类型字段]]>
        public Form2(DelShowMsg delShowMsg)
        {
            //将传入的委托参数赋值给委托类型的字段
            this._delShowMsg = delShowMsg;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///<![CDATA[8.点击窗体2按钮事件时,将TextBox中的值传给委托字段]]>
            _delShowMsg(textBox1.Text);
        }

        ///<![CDATA[5.问题2:怎样将方法从Form1传到Form2中
        ///         分析:因为在Form1的按钮事件中创建了Form2的对象,
        ///         创建窗体2对象的时候调用了构造函数,通过构造函数
        ///         将方法从Form1传到Form2中]]>
    }
}
