/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年9月23日 星期三 13:45:21
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
using System.Threading;
using System.Text.RegularExpressions;
using System.Net;

namespace Day04_06.抓取网页的img_src带参数的图片链接_并下载
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 下载图片存储路径
        /// </summary>
        private static string Path = AppDomain.CurrentDomain.BaseDirectory + "IMG"; 
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 抓取按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bGrab_Click(object sender, EventArgs e)
        {
            //获取用户输入的url地址---Trim()去除输入内容前后的空白字符
            string url = tbUrlPath.Text.Trim();
            //判断网址是否为空,为空则提示
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("请先输入URL!");
                return;
            }
            //Log栏记录开始信息:
            rtLog.AppendText("开始抓取中....\r\n");
            //开启抓取图片方法的线程
            Thread thread = new Thread(() => Grab(url)) { IsBackground = true };
            thread.Start();
        }
        /// <summary>
        /// 抓取图片的方法
        /// </summary>
        /// <param name="url">目标网址</param>
        /// <returns></returns>
        private void Grab(string url)
        {
            //[<=1=>]根据全局图片存储路径实例化文件夹
            DirectoryInfo directoryInfo = new DirectoryInfo(Path);
            //判断此文件加是否存在,存在则删除
            if (Directory.Exists(Path))
            {
                directoryInfo.Delete(true);
            }
            //再重建此文件目录
            Directory.CreateDirectory(Path);
            //调用WebClient请求获取html代码
            WebClient webClient = new WebClient();
            string html = webClient.DownloadString(url);
            //正则表达式获取目标网页真实解码格式
            string decode = Regex.Match(html, @"charset=[\S\s]{1,10}.").Value;
            //防止乱码,转成小写判断是否为gbk或者为gb2312格式,是则采用默认编码格式
            if (decode.ToLower().Contains("gbk") || decode.ToLower().Contains("gb2312"))
            {
                webClient.Encoding = Encoding.Default;
                //再使用新的解码格式下载页面字符串
                html = webClient.DownloadString(url);
            }
            //定义url头部分,便于后面拼接新的url
            string urlTou = Regex.Match(url, @".+.com").Value;
            //正则表达式获取标题
            string title = Regex.Match(html, @"<title>(.+)</title>").Groups[1].Value;
            //控件委托写入标题
            tbTitle.Invoke(new Action(() =>
            {
                tbTitle.Text = Regex.Replace(title, @"[_]","-");
            }));
            #region 自动下一页图片下载
            //正则匹配所有页面的连接
            MatchCollection matchesUrls = Regex.Matches(html, @"<a\shref=""((/4kmeinv/index)([0-9\S]{0,4}).html)"">([0-9]{1,3})</a>");
            //最大页码数为页码总数
            int pageCount = int.Parse(matchesUrls[matchesUrls.Count - 1].Groups[4].Value);
            //定义页矩
            int pageStep = 0;
            //定义分隔符
            string spare = null;
            //定义名称字符串集合
            string[] fileName = null;
            //获取首页和第二页的不同,找出分隔符
            int diffIndex = sCompare(url.Substring(urlTou.Length), matchesUrls[0].Groups[1].Value, out pageStep, out spare);
            //循环所有网页
            for (int i = 0; i< pageCount;i++)
            {
                //拼接所有url
                url = i == 0 ? url : urlTou + matchesUrls[0].Groups[2].Value + spare + (i+1) + ".html";
                //下载每一页的html代码
                html = webClient.DownloadString(url);
                //[<=2=>]调用GetHtmlImagesUrlList函数获取当前页所有图片下载路径
                string[] allImgUrls = GetHtmlImagesUrlList(html, urlTou,out fileName);
                //遍历下载当前页所有图片
                for (int j = 0;j< allImgUrls.Length;j++)
                {
                    //下载图片
                    webClient.DownloadFile(allImgUrls[j], Path + "\\" + fileName[j]);
                    //控件委托写入已下载的log信息
                    rtLog.Invoke(new Action(() =>
                    {
                        rtLog.AppendText(allImgUrls[j] + "\r\n");
                    }));
                }
            }
            //最后抓取完成写入log信息
            rtLog.Invoke(new Action(() =>
            {
                rtLog.AppendText("全部抓取完成" + "\r\n");
            }));
            #endregion
        }
        /// <summary>
        /// 获取HTML中所有图片的url
        /// </summary>
        /// <param name="html">HTML代码</param>
        /// <returns>所有图片的url列表</returns>
        private string[] GetHtmlImagesUrlList(string html,string urlTou,out string[] fileName)
        {
            //定义正则表达式来匹配img标签并搜索匹配字符串
            MatchCollection matches = Regex.Matches(html, @"<img\ssrc=""(/uploads/allimg/[0-9]{6}/([0-9a-zA-Z-]{21}.jpg))""");
            //实例化字符数组来存储匹配到的图片地址集合
            string[] sUrlList = new string[matches.Count];
            fileName = new string[matches.Count];
            //将匹配内容拼接成全路径存储到集合中
            for (int i=0;i< matches.Count;i++)
            {
                sUrlList[i] = urlTou + matches[i].Groups[1].Value;
                fileName[i] = matches[i].Groups[2].Value;
            }
            return sUrlList;
        }
        /// <summary>
        /// 字符串比较不同
        /// </summary>
        /// <param name="strFirst">第一个字符串</param>
        /// <param name="strNext">第二个字符串</param>
        /// <param name="nextNum">下页码</param>
        /// <param name="spare">分隔符</param>
        /// <returns></returns>
        private static int sCompare(string strFirst, string strNext, out int nextNum, out string spare)
        {
            spare = null;
            nextNum = 0;
            int index = 0;
            string tou = null;
            string wei = null;
            strFirst = strFirst.Substring(0, strFirst.LastIndexOf("."));
            strNext = strNext.Substring(0, strNext.LastIndexOf("."));
            //获取两个字符串的最短长度
            int n = strFirst.Length > strNext.Length ? strNext.Length : strFirst.Length;/*获得较短的字符串的长度*/
            //两个字符串长度不等
            if (strFirst.Length != strNext.Length)
            {
                //第二字符串包含第一字符串
                if (strNext.Contains(strFirst))
                {
                    //第二字符串减去第一字符串部分是否有分隔符
                    if (Regex.IsMatch(strNext.Substring(strFirst.Length), @"[_-]"))
                    {
                        //获取出分隔符
                        spare = Regex.Match(strNext.Substring(strFirst.Length), @"\D").Value;
                        //获取第二页的页码
                        nextNum = int.Parse(Regex.Match(strNext.Substring(strFirst.Length), @"\d+").Value);
                        //记录两者不同的起始序标
                        index = strFirst.Length;
                    }
                    else
                    {
                        //获取第二页的页码
                        nextNum = int.Parse(Regex.Match(strNext.Substring(strFirst.Length - 1), @"\d+").Value);
                        //记录两者不同的起始序标
                        index = strFirst.Length;
                    }
                }
                //第二字符串不包含第一字符串
                else
                {
                    //遍历寻找不同
                    for (int i = 0; i < n; i++)
                    {
                        if (strFirst.Substring(i, 1) != strNext.Substring(i, 1))
                        {
                            //找到不同,记录两者不同的起始序标
                            index = i;
                            //切出头字符串
                            tou = strFirst.Substring(i + 1);
                            if (strNext.LastIndexOf(tou) + tou.Length == strNext.Length)
                            {
                                //切出尾字符串
                                wei = strNext.Substring(i);
                                //去除头尾,剩下第二页的页码
                                nextNum = int.Parse(strNext.Substring(i).Remove(strNext.Substring(i).Length - tou.Length));
                            }
                        }
                    }
                }
            }
            else
            {
                //两字符串长度相等,遍历比较不同
                for (int i = 0; i < n; i++)
                {
                    if (strFirst.Substring(i, 1) != strNext.Substring(i, 1))
                    {
                        //找到不同,记录两者不同的起始序标
                        index = i;
                        //切出第二页的页码
                        nextNum = int.Parse(Regex.Match(strNext.Substring(i - 1), @"\d+").Value);
                    }
                }
            }
            //返回两者不同的起始序标
            return index;
        }
    }
}
