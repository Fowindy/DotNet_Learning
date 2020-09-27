/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月26日 星期六 15:29:32
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月26日 星期六 15:29:32
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

namespace Day06_02.委托_窗体之间传值
{
    public delegate void MyDel(string input);
    public partial class Form1 : Form
    {
        //1.先定义一个私有的子窗口字段
        private Form2 form2;
        //11.定义一个用于接收子窗体实例方法的委托变量
        public MyDel form2Del = null;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 传值去第二个窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1_Click(object sender, EventArgs e)
        {
            //2.判断定义的子窗口字段是否为空或者已经释放
            if (form2 == null || form2.IsDisposed == true)
            {
                //3.为空或已释放则实例化(并将子窗口向父窗口返回信息的方法通过构造函数传参委托过去,方便后续子窗体听过此委托向主窗体返回数据)
                form2 = new Form2(ReturnValue);
                //12.接收子窗体的实例方法
                form2Del = form2.form2Del;
                //13.显示子窗体
                form2.Show();
            }
            //14.用子窗体的委托变量向子窗体传值
            form2Del(tb1.Text);
        }
        /// <summary>
        /// 4.父窗体的实例方法
        /// </summary>
        /// <param name="input"></param>
        public void ReturnValue(string input)
        {
            tb1.Text = input;
        }
    }
}
