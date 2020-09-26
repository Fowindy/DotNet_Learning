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
    public partial class FrmSingle : Form
    {
        #region 子窗体实现单例的逻辑
        /// <summary>
        /// 定义一个子窗体私有静态变量(保护,防止外部访问)
        /// </summary>
        private static FrmSingle frm;
        /// <summary>
        /// 给外部一个公有静态方法访问创建(公有:让外部可以访问;静态:让外部通过类名访问不需要实例化)
        /// </summary>
        /// <returns></returns>
        public static FrmSingle CreatForm()
        {
            //判断单个子窗体是否为空(没有创建)或者是否已经释放
            if (frm == null || frm.IsDisposed == true)
            {
                //如果是,则实例化一个窗口弹出
                frm = new FrmSingle();
            }
            //如果不是,则继续之前弹出的子窗口
            return frm;
        } 
        #endregion
        public FrmSingle()
        {
            InitializeComponent();
        }
    }
}
