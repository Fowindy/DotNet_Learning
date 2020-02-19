/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月19日 星期三 17:21:18
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.Day02_07.字符串练习.Listing07_02
{
    public class Listing07_02
    {
        public static void Main()
        {
            //07_02_01_实现的基本机构
            string str = "I Love You";
            str = ReverseByWord(str);
            Console.WriteLine(str);
        }
        //07_02_02_封装转换方法
        private static string ReverseByWord(string str)
        {
            //07_02_02_01_先用空格截取出每一个单词
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //07_02_02_02_遍历每一个单词
            for (int i = 0; i < words.Length; i++)
            {
            }
        }
    }
}
