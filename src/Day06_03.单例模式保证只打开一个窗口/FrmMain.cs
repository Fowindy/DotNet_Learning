using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day06_03.单例模式保证只打开一个窗口
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //单例模式实例化对象,保证多次点击只弹一次窗体
            FrmSingle frmSingle = FrmSingle.CreatForm();
            //让子窗体在父窗体内显示
            frmSingle.MdiParent = this;
            //显示子窗体
            frmSingle.Show();
        }
    }
}
