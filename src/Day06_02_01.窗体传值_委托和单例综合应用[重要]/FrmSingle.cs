using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day06_02_01.窗体传值_委托和单例综合应用_重要_
{
    public partial class FrmSingle : Form
    {
        /// <summary>
        /// 9.子窗体中定义公有子委托成员变量(公有:让父类可以访问)
        /// </summary>
        public MyDel _myDelZi;
        /// <summary>
        /// 10.子窗体中定义静态父委托成员变量(用以接收构造传过来的父实例)
        /// </summary>
        private static MyDel _myDelFu;
        #region 2.子窗体实现单例模式
        //2.1.定义一个子窗体类型的私有静态成员变量---外部不能访问,确保唯一实例
        private static FrmSingle frmSingle;
        //2.2.声明一个公有静态方法(公有:让外部可以访问;静态:让外部通过类名访问不需要通过实例化访问)
        public static FrmSingle CreatForm(MyDel myDelFu)
        {
            //2.3.判断当前实例是否为空或者已经释放资源
            if (frmSingle == null || frmSingle.IsDisposed == true)
            {
                //2.4.如果为空或已释放,则重新实例化
                frmSingle = new FrmSingle();
                //11.父委托成员变量接收父实例方法;
                _myDelFu = myDelFu;
            }
            //2.5.反之或最终直接返回当前实例
            return frmSingle;
        }
        #endregion
        public FrmSingle()
        {
            InitializeComponent();
            //12.子委托变量赋值子实例方法
            _myDelZi = GetValueToText_Zi;
        }
        /// <summary>
        /// 5.子窗体拿值(来自父窗体)到自身文本控件的实例方法
        /// </summary>
        /// <param name="value"></param>
        public void GetValueToText_Zi(string value)
        {
            tbSingle.Text = value;
        }
        /// <summary>
        /// 12.子按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSingle_Click(object sender, EventArgs e)
        {
            //子窗体输入内容通过父委托到父界面显示
            _myDelFu(tbSingle.Text);
        }
    }
}
