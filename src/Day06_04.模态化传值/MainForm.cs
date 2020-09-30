/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月27日 星期日 09:09:25
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月27日 星期日 09:09:25
 *          修改理由：创建文档
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

namespace Day06_04.模态化传值
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private MyDialog m_dlg;

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MyDialog dlg = new MyDialog(richTextBox1.Text);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = dlg.TextBoxValue;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (m_dlg == null)
            {
                m_dlg = new MyDialog(richTextBox1.Text);
                m_dlg.TextBoxChanged += new EventHandler(
                    (sender1, e1) =>
                    {
                        richTextBox1.Text = m_dlg.TextBoxValue;
                    }
                );
                m_dlg.FormClosed += new FormClosedEventHandler(
                    (sender2, e2) => { m_dlg = null; }
                );
                m_dlg.Show(this);
            }
            else
            {
                m_dlg.Activate();
            }
        }
    }
}
