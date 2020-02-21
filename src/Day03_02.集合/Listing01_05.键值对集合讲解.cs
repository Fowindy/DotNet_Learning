/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月21日 星期五 09:03:23
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.Day03_02.集合.Listing01_05
{
    public class Listing01_05
    {
        public static void Main()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            //01_往Dictionary中添加与元素
            dic.Add("yzk", "杨中科");
            dic.Add("zxh", "赵小虎");
            dic.Add("jk", "姜昆");
            //02_遍历键值对中所有的键
            foreach (string item in dic.Keys)
            {
                Console.WriteLine(item);
            }
            //03_遍历键值对中所有的值
            foreach (string item in dic.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------04_遍历键值对中所有的键值对----------------");
            foreach (KeyValuePair<string,string> item in dic)
            {
                Console.WriteLine(item.Key+"==="+item.Value);
            }
        }
    }
}
