/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月23日 星期日 09:54:24
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day03_03.英汉字典
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //02_加载界面的时候收录字典
        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            //02_01_读取字典文件
            string[] Lines = File.ReadAllLines("../../相关资料/字典.txt", Encoding.Default);

        }
    }
}
