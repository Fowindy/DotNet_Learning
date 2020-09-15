/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月20日 星期四 23:00:40
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.Day03_02.集合.Listing01_03
{
    public class Listing01_03
    {
        public static void Main()
        {
            //案例2:两个list集合;集合{'a','b','c','d','e'}和{'d','e','f','g','h'},
            //把这两个集合去除重复合并成一个
            List<char> list1 = new List<char> { 'a', 'b', 'c', 'd', 'e' };
            List<char> list2 = new List<char> { 'd', 'e', 'f', 'g', 'h' };
            for (int i = 0; i < list2.Count; i++)
            {
                //01_遍历list1中是否存在list2中的元素_不存在则添加到list1中
                if (!list1.Contains(list2[i]))
                {
                    list1.Add(list2[i]);
                }
            }
            //02_遍历打印合并后的集合
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i]);
            }
        }
    }
}
