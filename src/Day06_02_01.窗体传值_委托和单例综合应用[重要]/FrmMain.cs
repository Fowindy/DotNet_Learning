/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月27日 星期日 16:04:17
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月27日 星期日 16:04:17
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

namespace Day06_02_01.窗体传值_委托和单例综合应用_重要_
{
    /// <summary>
    /// 6.定义委托类型
    /// </summary>
    /// <param name="value"></param>
    public delegate void MyDel(string value);
    public partial class FrmMain : Form
    {
        /// <summary>
        /// 7.在父窗体中定义子的委托成员变量(用于接收子窗口传过来的实例方法)
        /// </summary>
        private MyDel myDelZi;
        public FrmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 3.父窗体向子窗体传值事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bMain_Click(object sender, EventArgs e)
        {
            //3.1.实例化子窗体(不能使用new的方式,使用单例模式的方式)
            #region 8.父按钮委托交互
            //8.1.在父按钮事件中把父实例方法通过构造函数委托给子窗口
            FrmSingle frmSingle = FrmSingle.CreatForm(GetValueToText_Fu);
            //8.1.拿到子窗体公有的委托的实例方法
            myDelZi = frmSingle._myDelZi;
            //8.2.父窗体输入的内容通过子委托到子界面显示
            myDelZi(tbMain.Text); 
            #endregion
            //3.2.显示子窗体
            frmSingle.Show();
        }
        /// <summary>
        /// 4.父窗体拿值(来自子窗体)到自身文本控件的实例方法
        /// </summary>
        /// <param name="value"></param>
        public void GetValueToText_Fu(string value)
        {
            tbMain.Text = value;
        }
    }
}
