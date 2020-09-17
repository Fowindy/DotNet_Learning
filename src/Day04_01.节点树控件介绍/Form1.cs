/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年9月16日 星期三 09:29:39
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

namespace Day04_01.节点树控件介绍
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bAddRootNode_Click(object sender, EventArgs e)
        {
            //添加根节点
            tv.Nodes.Add(tbRootNode.Text);
        }

        private void bAddChildNode_Click(object sender, EventArgs e)
        {
            //往选中节点中添加子节点
            tv.SelectedNode.Nodes.Add(tbChildNode.Text);
        }

        private void bRemoveCurNode_Click(object sender, EventArgs e)
        {
            //删除当前选中节点(含子节点)
            tv.SelectedNode.Remove();
        }
    }
}
