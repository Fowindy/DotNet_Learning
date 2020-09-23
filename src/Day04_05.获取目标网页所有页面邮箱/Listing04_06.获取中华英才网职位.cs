/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月22日 星期二 23:25:28
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月22日 星期二 23:25:28
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace Fowindy.Day04_05.获取目标网页所有页面邮箱.Listing04_06
{
    public class Listing04_06
    {
        public static void Main()
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.Default;
            MatchCollection matches = null;
            MatchCollection matchesItem = null;
            string url1 = "http://www.chinahr.com/channel/szkunshan/pn1/";
            string html = webClient.DownloadString(url1);
            //正则表达式匹配网址Groups[1],匹配页码Groups[2]
            matches =  Regex.Matches(html, @"href=""//(www.chinahr.com/channel/szkunshan/pn([0-9]{1,2})/)""");
            foreach (Match item in matches)
            {
                url1 = item.Groups[1].Value;
                html = webClient.DownloadString(@"http://" + url1);
                matchesItem = Regex.Matches(html, @"<h1\stitle=""(.+)"">(.+)</h1>");
                foreach (Match match in matchesItem)
                {
                    Console.WriteLine(match.Groups[1].Value);
                }
            }
        }
    }
}
