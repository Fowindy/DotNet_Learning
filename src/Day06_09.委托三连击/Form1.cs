using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day06_09.委托三连击
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体Load事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            utc._mdl = DoSomething;
        }

        private void DoSomething()
        {
            MessageBox.Show("点了三次");
        }

        private void userThreeClick1_Load(object sender, EventArgs e)
        {
        }
        //委托的弊端1
        //如果最开始点这个按钮,委托的实例方法会变成这个,然后自定义控件按钮点三次将会显示Say的内容
        private void button1_Click(object sender, EventArgs e)
        {
            utc._mdl = Say;
        }

        private void Say()
        {
            MessageBox.Show("我也是点三下显示的");
        }
    }
}
