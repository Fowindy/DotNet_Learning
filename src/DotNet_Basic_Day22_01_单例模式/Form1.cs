﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNet_Basic_Day22_01_单例模式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //$1.1.在Form1中建一个按钮,用于弹出Form2
            //实例化form2窗口对象
            Form2 form2 = new Form2();
            //显示form2窗口
            form2.Show();
        }
    }
}
