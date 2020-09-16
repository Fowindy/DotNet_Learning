﻿/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年9月16日 星期三 10:25:24
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

namespace Day04_02.资料管理器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string path;
        //加载事件
        private void Form1_Load(object sender, EventArgs e)
        {
            //先获取路径
            path = "demo";
            //往tv节点树中加载文件和文件夹
            LoadFileAndDirectory(path, tv.Nodes);
        }

        private void LoadFileAndDirectory(string path, TreeNodeCollection nodes)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (var dir in dirs)
                {
                    string dirName = Path.GetFileName(dir);
                    TreeNode treeNode = nodes.Add(dirName);
                    //递归遍历的实现
                    LoadFileAndDirectory(dir, treeNode.Nodes);
                }

                //获取路径下的所有文件路径
                string[] files = Directory.GetFiles(path);
                //根据这个路径获取该路径下的所有文件名字
                for (int i = 0; i < files.Length; i++)
                {
                    string fileName = Path.GetFileNameWithoutExtension(files[i]);
                    TreeNode treeNodeFile = nodes.Add(fileName);
                    //递归遍历的实现
                    LoadFileAndDirectory(files[i], treeNodeFile.Nodes);
                    //把文件的路径绑定在tag属性上
                    treeNodeFile.Tag = files[i];
                }
            }
            catch
            {

            }

        }

        private void bPathLoad_Click(object sender, EventArgs e)
        {
            tv.Nodes.Clear();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;
                if (path != null)
                {
                    LoadFileAndDirectory(path, tv.Nodes);
                }
            }
        }
        private void tv_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //双击节点显示内容_采用e事件调用_推荐
            //if (e.Node.Tag != null)
            //{
            //    tbShowDetail.Text = File.ReadAllText(e.Node.Tag.ToString(), Encoding.Default);
            //}

            //双击节点显示内容_采用树事件调用
            if (tv.SelectedNode.Tag != null)
            {
                tbShowDetail.Text = File.ReadAllText(tv.SelectedNode.Tag.ToString(), Encoding.Default);
            }
        }
    }
}
