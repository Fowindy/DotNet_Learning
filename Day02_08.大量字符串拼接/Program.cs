/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月20日 星期四 02:09:42
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day02_08.大量字符串拼接
{
    public class Program
    {
        static void Main(string[] args)
        {
            //01_拼接一个网页
            StringBuilder sb = new StringBuilder();
            sb.Append("<html>");
            sb.Append("<head>");
            sb.Append("<title>我的网页</title>");
            sb.Append("</head>");
            sb.Append("<body>");
            sb.Append(@"<font face = ""全新硬笔行书简"" size =""7"" color = ""red"">哈哈,我又变帅了</font><br/>");
            sb.Append("</body>");
            sb.Append("</html>");
        }
    }
}
