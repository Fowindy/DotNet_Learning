/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月22日 星期二 19:17:12
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月22日 星期二 19:17:12
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace Fowindy.Day04_05.获取目标网页所有页面邮箱.Listing04_05
{
    public class Listing04_05
    {
        public static void Main()
        {
            #region 1.实例化WebClient对象来初步解析网页数据
            //1.1 实例化WebClient对象用于解析网页数据
            WebClient client = new WebClient();
            //1.2 设置默认解码格式为UTF8(最常见的解码格式)
            client.Encoding = Encoding.UTF8;
            //1.3 定义目标变量拿到目标网址 
                //1.3.1 测试网页如下,可粘贴测试:
                //http://bbs.chinaacc.com/forum-2-31/topic-779665.html
                //http://bbs.gongkong.com/D/200411/57812/57812_1.shtml
                //http://bbs.tianya.cn/post-english-129176-1.shtml
                //https://bbs.bianzhirensheng.com/thread-864299-1-1.html
                //https://www.jb51.net/list/list_85_1.htm
            string url1 = "http://bbs.gongkong.com/D/200411/57812/57812_1.shtml";
            //1.4 下载目标网页字符串
            string html = client.DownloadString(url1);
            //1.5 正则表达式获取目标网页真实解码格式
            string decode = Regex.Match(html, @"charset=[\S\s]{1,10}.").Value;
            //1.6 防止乱码,转成小写判断是否为gbk或者为gb2312格式,是则采用默认编码格式
            if (decode.ToLower().Contains("gbk") || decode.ToLower().Contains("gb2312"))
            {
                client.Encoding = Encoding.Default;
                //1.6.1 再使用新的解码格式下载页面字符串
                html = client.DownloadString(url1);
            }
            #endregion
            #region 2.解析分析网页首页和下一页(第二页或者末页)网址的不同,获取页距和总页数
            //2.1 正则解析获取html中含有下?页的语句(下一页或下页)
            //href ="57812_2.shtml" class="next_pager psyy" >下一页
            string temp = Regex.Match(html, @"href=[\S\s]{1,70}下[\S\s]?页").Value.Substring(Regex.Match(html, @"href=[\S\s]{1,70}下[\S\s]?页").Value.LastIndexOf("href"));
            //2.2 将temp信息进一步解析处理(出去一些多余的部分)
                //57812_2.shtm
            string str2 = Regex.Match(temp, @"[\W][A-Za-z0-9][\S\s]*htm").Value.Replace("\"", "");
                //57812_2
            str2 = str2.Substring(0, str2.LastIndexOf('.'));
            //2.3 将首页处理成与第二页相同格式(字符串截取的使用)
                //57812_1.shtm
            string str1 = url1.Substring(url1.LastIndexOf(str2.Substring(0, 6)));
                //57812_1
            str1 = str1.Substring(0, str1.LastIndexOf('.'));
            //2.4 调用字符比较的函数获取str1和str2的不同,返回不同开始的index以及内容
            int stepCount = 0;//定义第二页页码
            string divide = null;//定义分隔符
                  //6               //57812_1  57812_2      2               null
            int diffIndex = sCompare(str1, str2, out stepCount, out divide);
            //2.5 计算出整个网址不同的起始序标
                //45
            int index = url1.LastIndexOf(str2.Substring(0, 6)) + diffIndex;
            //2.6 计算页矩(首页从1开始则减1,从0开始则减0)
                //1
            stepCount = divide == null ? stepCount - 1 : stepCount -0;
            //2.7 同理,获取首页和末页的所有页矩
            try
            {
                //2.7.1 先定义所有页数为0
                int pageCount = 0;
                //2.7.2 正则解析获取html中含有尾页或末页的语句
                    //href="57812_8.shtml" class="last_pager psy" >尾页
                string tempMax = Regex.Match(html, @"href=[\S\s]{1,70}(末页|尾页)").Value.Substring(Regex.Match(html, @"href=[\S\s]{1,70}(末页|尾页)").Value.LastIndexOf("href"));
                //2.7.3 将tempMax信息进一步解析处理(出去一些多余的部分)
                    //57812_8.shtm
                string str2Max = Regex.Match(tempMax, @"[\W][A-Za-z0-9][\S\s]*htm").Value.Replace("\"", "");
                    //57812_8
                str2Max = str2Max.Substring(0, str2Max.LastIndexOf('.'));
                //2.7.4 调用字符比较的函数获取str1和str2Max的不同,返回不同开始的index以及内容
                    //6               //57812_1  57812_8      8               null
                int endIndex = sCompare(str1, str2Max, out pageCount, out divide);
                //2.7.5 计算所有页数(首页从0开始则需加上页矩)
                    //8
                pageCount = divide == null ? pageCount : pageCount + stepCount;
            }
            catch (Exception)
            {
            }
            #endregion

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
            //获取两个字符串的最短长度
            int n = strFirst.Length > strNext.Length ? strNext.Length : strFirst.Length;/*获得较短的字符串的长度*/
            //两个字符串长度不等
            if (strFirst.Length != strNext.Length)
            {
                //第二字符串包含第一字符串
                if (strNext.Contains(strFirst))
                {
                    //第二字符串减去第一字符串部分是否有分隔符
                    if (Regex.IsMatch(strNext.Substring(strFirst.Length), @"\W+"))
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
