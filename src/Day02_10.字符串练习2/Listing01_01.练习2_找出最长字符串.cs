/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月20日 星期四 12:00:55
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.Day02_10.字符串练习2.Listing01_01
{
    public class Listing01_01
    {
        public static void Main()
        {
            //练习2. { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" },请输出最长的字符串
            string[] strs = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            //01_01_01_定义长度length和序标index变量
            int length = strs[0].Length;
            int index = 0;
            //01_01_02_循环判断字符数组中每个字符串的长度
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length > length)
                {
                    length = strs[i].Length;
                    index = i;
                }
            }
            Console.WriteLine(strs[index]);
            //01_01_03_第二种方法_封装方法实现
            string longName = GetMaxLengthNameByStringArray(strs);
        }
        private static string GetMaxLengthNameByStringArray(string[] strs)
        {
            string str = strs[0];
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length > str.Length)
                {
                    str = strs[i];
                }
            }
            return str;
        }
    }
}
