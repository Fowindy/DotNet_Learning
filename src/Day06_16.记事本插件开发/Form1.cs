/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月29日 星期二 12:26:15
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月29日 星期二 12:26:15
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
using System.Reflection;
using Day06_17.IEditPlus接口;

namespace Day06_16.记事本插件开发
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 1.记事本Load事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //1.1.窗体加载,扫描可执行路径/Lib文件路径的dll文件
            //---Assembly.GetExecutingAssembly().Location---包含可行性文件的全路径
            //---Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)---获取当前执行文件所在文件夹路径
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Lib");//拼组Lib路径
            //1.2.搜索Lib路径中的dll文件(插件)
            string[] files = Directory.GetFiles(path, "*.dll");
            //1.3.遍历所有dll文件
            for (int i = 0; i < files.Length; i++)
            {
                //1.3.1.获取该dll文件中所有的程序集(插件)
                Assembly ass = Assembly.LoadFile(files[i]);
                //1.3.2.获取该dll文件所有的types
                Type[] types = ass.GetTypes();
                #region 1.3.3.插件接口验证--->2.制作IEditPlus接口类
                //1.3.4.获取接口的类型(接口)
                Type iEdi = typeof(IEditPlus);
                //1.3.5.再遍历插件中所有的类,判断是否遵循主程序的接口规范
                for (int j = 0; j < types.Length; j++)
                {
                    MethodInfo[] methods = types[i].GetMethods();
                    //1.3.6.如果插件类继承接口类并且不是抽象类
                    if (iEdi.IsAssignableFrom(types[i]) && !types[j].IsAbstract)
                    {
                        //1.3.7.将此插件转换成接口对象
                        IEditPlus plus = (IEditPlus)Activator.CreateInstance(types[j]);
                        //1.3.8.为menuStrip1的Format菜单增加下拉按钮,并返回按钮对象
                        ToolStripItem tsp = Format.DropDownItems.Add(plus.Name);
                        //1.3.9.把插件转换的接口对象存储到按钮的tag属性中
                        tsp.Tag = plus;
                        //1.3.10.单击事件-->1.4.按钮点击事件
                        tsp.Click += new EventHandler(tsp_Click);
                    }
                }
                #endregion
            }
        }
        /// <summary>
        /// 1.4.按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsp_Click(object sender, EventArgs e)
        {
            //1.4.1.子类按钮对象转换成父类
            ToolStripItem tsp = sender as ToolStripItem;
            //1.4.2.把插件对象转换成接口分类对象
            IEditPlus iep = tsp.Tag as IEditPlus;
            //1.4.3.根据枚举方法执行相应功能
            switch (iep.methodEnum)
            {
                case MethodEnum.StringFormat:
                    rtbContent.Text = iep.StringFormat(rtbContent);
                    break;
                case MethodEnum.StringCount:
                    MessageBox.Show($"字符数为:{iep.StringCount(rtbContent)}");
                    break;
                case MethodEnum.SetColor:
                    iep.SetColor(rtbContent);
                    break;
                default:
                    break;
            }
        }
    }
}
