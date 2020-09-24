/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年9月24日 星期四 23:57:16
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

namespace Day05_03.xml文件登录
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 登录按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bLogin_Click(object sender, EventArgs e)
        {
            //1.存储用户输入的账户和密码
            string account = tbAccount.Text.Trim();
            string passWord = tbPassWord.Text.Trim();
            //2.登录成功与否的方法
            if (XmlLoginOrNot(account, passWord))
            {
                MessageBox.Show("登录成功!");
            }
            else
            {
                MessageBox.Show("登录失败!");
            }
        }
        /// <summary>
        /// 2.1.登录成功与否的方法
        /// </summary>
        /// <param name="account">账号</param>
        /// <param name="passWord">密码</param>
        /// <returns></returns>
        private bool XmlLoginOrNot(string account, string passWord)
        {
            //2.1.5.实例化user类的集合对象==>2.1.5.1.创建user类
            List<user> userLists = new List<user>();
            //2.1.1.实例化xml文件对象并读取xml内容
            XDocument xdoc = XDocument.Load(@"..\..\相关资料\UserData.xml");
            //2.1.2.实例化root元素对象存储根元素
            XElement root = xdoc.Root;
            //2.1.3.遍历根节点下隶属节点
            foreach (XElement user in root.Elements())
            {
                //2.1.4.将读取到的内容存入用户类user的集合中
                userLists.Add(new user() { Name = user.Element("name").Value, Id = user.Attribute("id").Value, PassWord = user.Element("password").Value });
            }
            //2.1.6.判断登录成功与否==>2.登录成功与否的方法
            for (int i= 0;i<userLists.Count;i++)
            {
                if (userLists[i].Name == account && userLists[i].PassWord == passWord)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
