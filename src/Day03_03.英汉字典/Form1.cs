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
            string[] words = null;
            //02_02_遍历每一行的字符串
            for (int i = 0; i < Lines.Length; i++)
            {
                //02_02_01_通过分析英文单词和中文翻译之间用空格隔开_可以通过split提取
                words = Lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                //02_02_02_因为可能行中有多个空格_除了第一个空格后面的全部认为是翻译部分合并
                for (int j = 1; j < words.Length; j++)
                {
                    words[1] += words[j];
                }
                //02_02_03_如果字典中已存在该单词(key)则直接累加汉语翻译_如果不存在则添加到键值对集合中
                if (!dic.ContainsKey(words[0]))
                {
                    dic.Add(words[0], words[1]);
                }
                else
                {
                    dic[words[0]] += words[1];
                }
            }
        }
        //03_翻译按钮事件
        private void btnTranslate_Click(object sender, EventArgs e)
        {

        }
    }
}
