/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月19日 星期三 22:42:49
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.Day02_07.字符串练习.Listing07_07
{
    public class Listing07_07
    {
        public static void Main()
        {
            //练习7：“192.168.10.5[port=21,type=ftp]”，这个字符串表示IP地址为192.168.10.5的服务器的21端口提供的是ftp服务，其中如果“,type=ftp”部分被省略，
            //则默认为http服务。请用程序解析此字符串，然后打印出“IP地址为***的服务器的***端口提供的服务为***” 
            //line.Contains(“type=”)。192.168.10.5[port=21]
            string str = "192.168.10.5[port=21,]";
            string type = null;
            if (!str.Contains("type="))
            {
                type = "http";
            }
            string[] strs = str.Split(new char[] { '[', ']', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string ip = strs[0];
            string port = null;
            if (strs[1].Contains("port="))
            {
                port = strs[1].Split('=', StringSplitOptions.RemoveEmptyEntries)[1];
            }
            if (type == null)
            {
                type = strs[2].Split('=')[1];
            }
            Console.WriteLine("IP地址为{0}的服务器的{1}端口提供的服务为{2}",ip,port,type);
        }
    }
}
