/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月28日 星期一 17:14:09
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月28日 星期一 17:14:09
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

namespace Day06_10.委托三连击_事件实现
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyClick1._mdl += DoSomething;
        }

        private void DoSomething()
        {
            MessageBox.Show("点击三次才执行");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //事件与委托的区别1:
            //委托可以直接调用,事件不可以直接调用
            //MyClick1._mdl();
            MyClick1._mdl += Say;
            //点击此按钮。只是将实例方法。加载到事件中。点击一下执行一次;真正显示还是得用户自定义的控件点击三下后
            //先显示用户控件点击的方法后再按要求的次数执行Say方法
        }

        private void Say()
        {
            MessageBox.Show("哈哈哈");
        }
    }
}
