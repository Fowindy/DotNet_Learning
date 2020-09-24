/* ==============================================================================
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
        }
    }
}
