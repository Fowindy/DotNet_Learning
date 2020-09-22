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
        }
    }
}
