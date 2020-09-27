using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day06_02.委托_窗体之间传值
{
    public partial class Form2 : Form
    {
        //5.子窗体中定义公有的子窗体委托变量,用以把子窗体的实例方法传到父窗体
        public MyDel form2Del = null;
        //6.子窗口中定义父窗口委托变量,用于接收从父窗口委托过来的实例方法
        private MyDel form1Del = null;
        //7.构造函数参数拿到了父窗体传过来的实例方法
        public Form2(MyDel myDel)
        {
            InitializeComponent();
            //8.将父窗体的实例方法赋值给父窗口委托变量
            form1Del = myDel;
            //9.将子窗体的实例方法赋值给子窗体的委托变量
            form2Del = SetValue;
        }
        /// <summary>
        /// 10.子窗体的实例方法
        /// </summary>
        /// <param name="input"></param>
        public void SetValue(string input)
        {
            tb2.Text = input;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            //15.用父窗体的委托变量向在父窗体传值
            form1Del(tb2.Text);
        }
    }
}
