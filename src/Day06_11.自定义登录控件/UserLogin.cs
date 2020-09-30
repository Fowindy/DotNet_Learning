using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day06_11.自定义登录控件
{
    public partial class UserLogin : UserControl
    {
        public UserLogin()
        {
            InitializeComponent();
        }
        /************************************************************************/
        /* 实现思路如下:
         * 1.自定义登录控件包含账号密码输入框和登录点击按钮
           2.用户操作就是点击按钮然后返回结果(账号和密码是否都正确)
           3.自定义登录控件拿到用户登录结果背景显示红色或绿色*/
        /************************************************************************/
        /// <summary>
        /// 声明事件
        /// </summary>
        public event EventHandler evt;
        /// <summary>
        /// 登录按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bUserLogin_Click(object sender, EventArgs e)
        {
            if (this.evt != null)
            {
                //实例化类---因为EventArgs类中没有需要定义的用户名和密码等属性,所以需要再建一个类继承EventArgs
                MyEventArgs myEct = new MyEventArgs();
                //拿到用户输入的账号和密码
                myEct.Name = tbName.Text;
                myEct.Password = tbPassword.Text;
                this.evt(this, myEct);
                //执行事件后判断,用户传过来的结果
                if (myEct.Result)
                {
                    this.BackColor = Color.Green;//成功绿色
                }
                else
                {
                    this.BackColor = Color.Red;//失败红色
                }
            }
        }
    }

    public class MyEventArgs: EventArgs
    {
        public MyEventArgs()
        {
            //默认为false
            this.Result = false;
        }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool Result { get; set; }
    }
}
