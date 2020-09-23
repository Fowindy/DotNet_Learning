/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月23日 星期三 11:34:44
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月23日 星期三 11:34:44
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace Fowindy.Day04_05.获取目标网页所有页面邮箱.Listing04_07
{
    public class Listing04_07
    {
        public static void Main()
        {
            WebClient webClient = new WebClient();
            string path = null;
            string url = "http://gb.cri.cn/42071/2013/11/23/5311s4332512.htm";
            string html = webClient.DownloadString(url);
            MatchCollection matches = Regex.Matches(html, @"<a\shref='(5311s4332512_([0-9]{1,3}).htm)'>([0-9]{1,3})</a>");
            int pageCount = int.Parse(matches[matches.Count - 1].Groups[3].Value);
            for (int i =0;i< pageCount;i++)
            {
                url = i == 0 ? url : "http://gb.cri.cn/42071/2013/11/23/5311s4332512_" + i+".htm";
                html = webClient.DownloadString(url);
                matches = Regex.Matches(html, @"<IMG\ssrc=""/mmsource/images/2013/11/23/(.+.jpg)"">");
                foreach (Match item in matches)
                {
                    if (item.Success)
                    {
                        path = "http://gb.cri.cn/mmsource/images/2013/11/23/" + item.Groups[1].Value;
                        webClient.DownloadFile(path, item.Groups[1].Value);
                    }
                }
            }
        }
    }
}
