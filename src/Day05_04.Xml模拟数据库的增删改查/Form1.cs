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
        //1.3.4.1.创建User类的集合=>2.1.创建User类
        //List<User> userLists = new List<User>();---[重要]list绑定dgv则无法实现删除动作,使用BindingList替代
        BindingList<User> userLists = new BindingList<User>();//本组数据
        //1.2.实例化xml文件对象
        XDocument xdoc = new XDocument();
        /// <summary>
        /// 1.1.加载xml数据到dgv显示函数
        /// </summary>
        private void LoadXmlToDgv()
        {
            //1.3.判断程序执行路径是否有目标xml文件
            if (File.Exists("UserData.xml"))
            {
                userLists.Clear();
                //1.3.2.存在则读取
                xdoc = XDocument.Load("UserData.xml");
                //1.3.3.实例化节点元素存储xml根节点
                //XElement users = xdoc.Root;
                //1.3.4.2.遍历xml元素并存储到集合
                foreach (XElement user in xdoc.Root.Elements())
                {
                    userLists.Add(new User() { Id = user.Attribute("id").Value, Name = user.Element("name").Value, PassWord = user.Element("password").Value });
                }
                //1.3.5.将读取到的集合数据绑定到dgv控件显示
                dgv.AutoGenerateColumns = false;//禁止自动生成列
                //1.3.6.dgv在重新刷新DataSource之前需将DataSource设置为null;不然不可刷新显示
                dgv.DataSource = null;
                dgv.DataSource = userLists;
                dgv.ClearSelection();//禁止选中任何行列
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
        /// <summary>
        /// 3.注册[增加]按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRegister_Click(object sender, EventArgs e)
        {
            //3.1.获取用户输入的内容
            string id = tbAddID.Text.Trim();
            string name = tbAddName.Text.Trim();
            string passWord = tbAddPassWord.Text.Trim();
            //3.2.判断用户输入内容是否为空
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(passWord))
            {
                //3.2.1.为空则提示
                MessageBox.Show("用户信息均不能为空!请确认!");
                return;
            }
            else//3.2.2.不为空则注册[添加]
            {
                for (int i = 0; i < userLists.Count; i++)
                {
                    //3.2.3.遍历集合中的id是否与输入id相等(检查id唯一性)
                    if (userLists[i].Id == id)
                    {
                        MessageBox.Show("学号已经存在,添加失败!请确认!");
                        return;
                    }
                }
                //3.2.4.将用户输入内容写到xml中
                XElement user = new XElement("user");
                user.SetAttributeValue("id", id);
                user.SetElementValue("name", name);
                user.SetElementValue("password", passWord);
                xdoc.Root.Add(user);
                xdoc.Save("UserData.xml");
                LoadXmlToDgv();
                MessageBox.Show("注册成功!");
                tbAddID.Clear();
                tbAddName.Clear();
                tbAddPassWord.Clear();
            }
        }
        /// <summary>
        /// 4.删除按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dgv.SelectedRows;
            if (dgv.SelectedRows.Count>0)
            {
                DialogResult result = MessageBox.Show("你确定要删除选定行的数据吗?", "删除数据", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //迭代删除选中行
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        //选中行的id
                        //string id = dgv.SelectedRows[row.Index].Cells[0].Value.ToString();
                        string id = dgv.Rows[row.Index].Cells[0].Value.ToString();
                        //使用Lamda表达式获取xml中的对象元素
                        XElement xele = xdoc.Root.Elements("user").Where(xy => xy.Attribute("id").Value == id).Single();
                        //删除当前user元素
                        xele.Remove();
                        //删除当前行<<1>>[二选一]
                        dgv.Rows.Remove(row);
                    }
                    //保存
                    xdoc.Save("UserData.xml");
                    //LoadXmlToDgv();<<2>>
                }
            }
        }
        /// <summary>
        /// 5.更新[修改]按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bUpdate_Click(object sender, EventArgs e)
        {
            //获取用户选中的行id
            string id = tbUpdateID.Text;
            //获取id根元素
            XElement xele = xdoc.Root.Elements("user").Where(x => x.Attribute("id").Value == id).Single();
            //修改后的用户名和密码不为空
            if (!string.IsNullOrEmpty(tbUpdateName.Text.Trim()) && !string.IsNullOrEmpty(tbUpdatePassWord.Text.Trim()))
            {
                //修改根元素的子项(学号不允许更改)
                xele.SetElementValue("name", tbUpdateName.Text.Trim());
                xele.SetElementValue("password", tbUpdatePassWord.Text.Trim());
                //保存xml
                xdoc.Save("UserData.xml");
                //成功提示
                MessageBox.Show("修改成功!");
                //界面刷新显示
                LoadXmlToDgv();
                //修改成功,清空文本框
                tbUpdatePassWord.Clear();
                tbUpdateName.Clear();
                tbUpdateID.Clear();
            }
            else
            {
                //失败提示
                MessageBox.Show("修改失败!用户名和密码为空!请确认!");
            }
        }
        /// <summary>
        /// 5.1.目标行被选中则将对象信息导入到文本框中待修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedRows.Count>0)//有被选中的行
            {
                //获取学号
                tbUpdateID.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
                //获取用户名
                tbUpdateName.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                //获取密码
                tbUpdatePassWord.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
            }
        }
    }
}
