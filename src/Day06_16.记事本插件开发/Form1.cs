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
            //1.2.搜索Lib路径中的dll文件
            string[] files = Directory.GetFiles(path, "*.dll");
            //1.3.遍历所有dll文件
            for (int i = 0; i < files.Length; i++)
            {
                //1.3.1.获取该dll文件中所有的程序集
                Assembly ass = Assembly.LoadFile(files[i]);
                //1.3.2.获取该dll文件所有的types
                Type[] types = ass.GetTypes();
                #region 1.3.3.插件接口验证--->2.制作IEditPlus接口类
                #endregion
            }
        }
    }
}
