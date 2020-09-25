/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年9月25日 星期五 07:36:24
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

namespace Day05_04.Xml模拟数据库的增删改查
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //1.加载xml数据到dgv显示=>1.1.加载xml数据到dgv显示函数
            LoadXmlToDgv();
        }
        /// <summary>
        /// 1.1.加载xml数据到dgv显示函数
        /// </summary>
        private void LoadXmlToDgv()
        {
            //1.2.实例化xml文件对象
            XDocument xdoc = new XDocument();
            //1.3.判断程序执行路径是否有目标xml文件
            if (File.Exists("UserData.xml"))
            {
                //1.3.2.存在则读取
                xdoc = XDocument.Load("UserData.xml");
                //1.3.3.实例化节点元素存储xml根节点
                XElement users = xdoc.Root;
                //1.3.4.遍历xml数据并存储到user类集合中
                //1.3.4.1.创建User类的集合=>2.1.创建User类
                List<User> userLists = new List<User>();
                //1.3.4.2.遍历xml元素并存储到集合
                foreach (XElement user in users.Elements())
                {
                    userLists.Add(new User() {Id = user.Attribute("id").Value,Name = user.Element("name").Value,PassWord = user.Element("password").Value });
                }
                //1.3.5.将读取到的集合数据绑定到dgv控件显示
                dgv.DataSource = userLists;
            }
            else
            {
                //1.3.1.不存在则创建该文件
                #region 往xdoc中添加节点元素
                XElement users = new XElement("users");
                xdoc.Add(users);
                xdoc.Save("UserData.xml");
                #endregion
            }
        }
        /// <summary>
        /// 显示行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }
    }
}
