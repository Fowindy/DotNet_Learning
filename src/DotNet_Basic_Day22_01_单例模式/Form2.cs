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
    public partial class Form2 : Form
    {
        //创建全局唯一的单例
        public static Form2 FrmSingle = null;
        //因为from2的构造函数为public,所以没办法单例;需要将form2构造函数私有化
        private Form2()
        {
            InitializeComponent();
        }

        //建立访问构造函数的静态方法,必须public,不然form1里面访问不了
        public static Form2 GetSingle()
        {
            //在自己的静态方法中实例化form2对象
            //判断是否为null,为null则创建,反之则不创建
            //$1.3.单例模式实现完成
            if (FrmSingle == null)
            {
                FrmSingle = new Form2();
            }
            else
            {
                MessageBox.Show("已经打开了一个应用");
            }
            return FrmSingle;
        }
    }
}
