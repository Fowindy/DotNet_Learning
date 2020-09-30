/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月28日 星期一 18:24:58
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月28日 星期一 18:24:58
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

namespace Day06_11.自定义登录控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //模拟系统事件
            MyUserLogin.evt += MyUserLogin_evt;
        }

        private void MyUserLogin_evt(object sender, EventArgs e)
        {
            //父类转子类对象
            MyEventArgs mea = e as MyEventArgs;
            if (mea.Name == "admin" && mea.Password == "123456")
            {
                mea.Result = true;
            }
            else
            {
                mea.Result = false;
            }
        }
    }
}
