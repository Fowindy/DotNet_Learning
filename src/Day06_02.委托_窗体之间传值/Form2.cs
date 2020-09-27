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
    public delegate void MyDel2(string txt);
    public partial class Form2 : Form
    {
        public static MyDel2 _myDel2;
        #region 单例模式
        private static Form2 form2;
        public static Form2 CreatForm(string input, MyDel2 myDel2)
        {
            if (form2 == null || form2.IsDisposed == true)
            {
                form2 = new Form2(input);
                _myDel2 = myDel2;
            }
            else
            {
                _myDel2 = myDel2;
            }
            return form2;
        }
        #endregion
        public Form2()
        {
            InitializeComponent();
        }
        //1-1.2.在窗体2中新建有参数的构造函数,并继承无参数狗在函数的初始化
        public Form2(string input):this()
        {
            tb2.Text = input;
        }
        public void SetValue12(string input)
        {
            tb2.Text = input;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            _myDel2(tb2.Text);
        }
    }
}
