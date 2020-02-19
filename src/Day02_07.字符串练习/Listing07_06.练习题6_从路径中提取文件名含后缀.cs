/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月19日 星期三 22:29:11
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.Day02_07.字符串练习.Listing07_06
{
    public class Listing07_06
    {
        public static void Main()
        {
            string str = @"C:\Users\Administrator\Desktop\应用程序临时文件路径更改.txt";
            //07_06_01_第一种方法:截取字符串
            string[] strs = str.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("文件名为:{0}",strs[strs.Length-1]);//应用程序临时文件路径更改.txt
        }
    }
}
