﻿using System;
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
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
