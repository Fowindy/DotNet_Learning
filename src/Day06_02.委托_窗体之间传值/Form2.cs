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
        public Form2()
        {
            InitializeComponent();
        }
        //1-1.2.在窗体2中新建有参数的构造函数,并继承无参数狗在函数的初始化
        public Form2(string input):this()
        {
            tb2.Text = input;
        }
    }
}
