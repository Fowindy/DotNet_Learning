﻿/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年9月24日 星期四 20:29:58
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace Day05_02.读取xml文件案例
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = null;
        /// <summary>
        /// 导入xml文件并生成树事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bLoadXmlToTree_Click(object sender, EventArgs e)
        {
            path = tbXmlPath.Text.Trim();
            if (string.IsNullOrEmpty(path))
            {
                if (FolderDialog.ShowDialog() == DialogResult.OK)
                {
                    path = FolderDialog.SelectedPath;
                    if (string.IsNullOrEmpty(path))
                    {
                        MessageBox.Show("路径为空!请先导入xml文件!!!");
                        return;
                    }
                    else
                    {
                        tbXmlPath.Text = path;
                    }
                }
            }
            //1.实例化xml文件对象并读取xml文件
            XDocument xdoc = XDocument.Load(path);
            //2.实例化root元素来存储xml文件的root元素
            XElement root = xdoc.Root;
            //3.将根元素的名字显示到节点树上
            treeView.Nodes.Add(root.Name.ToString());
        }
    }
}
