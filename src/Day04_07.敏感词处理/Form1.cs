/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年9月24日 星期四 08:29:54
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
using System.Text.RegularExpressions;

namespace Day04_07.敏感词处理
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 发帖类型枚举
        /// </summary>
        enum prohibitType
        {
            forbid = 0,//禁止发帖
            verify = 1,//需要审核
            enable = 2 //允许发帖
        }
        StringBuilder sbMod = new StringBuilder();
        StringBuilder sbBanned = new StringBuilder();
        /// <summary>
        /// 发帖按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bPost_Click(object sender, EventArgs e)
        {
            //首先拿到用户输入框中输入的的内容
            string input = tbInput.Text.Trim();
            //清空输出面板
            tbOutput.Text = null;
            //判断内容是否为空,为空则提示
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("发帖内容不能为空,请先输入发帖内容!");
                return;
            }
            //不为空则开始调用敏感词判断函数
            switch (SensitiveWordDetect(input))
            {
                case prohibitType.enable:
                    tbOutput.Text = input;
                    break;
                case prohibitType.forbid:
                    MessageBox.Show("内容含有敏感词汇,禁止发帖!");
                    break;
                case prohibitType.verify:
                    MessageBox.Show("内容含有敏感词汇,需要审核!");
                    break;
            }
        }
        /// <summary>
        /// 敏感词汇检测
        /// </summary>
        /// <param name="input">目标输入</param>
        /// <returns>侦测结果(发帖类型)</returns>
        private prohibitType SensitiveWordDetect(string input)
        {
            //首先读取敏感文件
            string[] allLines = File.ReadAllLines(@"..\..\相关资料\mg.txt", Encoding.Default);
            foreach (var item in allLines)
            {
                string[] Lines = item.Split(new string[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
                if (Lines[1].Contains("MOD"))
                {
                    sbMod.Append(Lines[0] + "|");
                }
                else if (Lines[1].Contains("BANNED"))
                {
                    sbBanned.Append(Lines[0] + "|");
                }
            }
            //移除最后的|,在正则表达式中相当于或
            sbMod.Remove(sbMod.Length-1, 1);
            sbBanned.Remove(sbBanned.Length-1, 1);
            if (Regex.IsMatch(input,sbMod.ToString()))
            {
                return prohibitType.verify;
            }
            else if (Regex.IsMatch(input,sbBanned.ToString()))
            {
                return prohibitType.forbid;
            }
            else
            {
                return prohibitType.enable;
            }
        }
    }
}
