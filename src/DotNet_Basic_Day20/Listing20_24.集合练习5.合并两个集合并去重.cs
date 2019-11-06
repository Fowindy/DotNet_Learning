/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2019年11月6日 星期三 12:48:45
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_24
{
    public class Listing20_24
    {
        public static void Main()
        {
            //集合练习5.合并两个集合并去重
            //案例：两个（List）集合{ “a”,“b”,“c”,“d”,“e”}和{ “d”, “e”, “f”, “g”, “h” }，把这两个集合去除重复项合并成一个。
            List<char> listOne = new List<char> {'a','b','c','d','e' };
            List<char> listTwo = new List<char> { 'd', 'e', 'f', 'g', 'h' };
            for (int i = 0; i < listTwo.Count; i++)
            {
                if (!listOne.Contains(listTwo[i]))
                {
                    listOne.Add(listTwo[i]);
                }
            }
            foreach (var item in listOne)
            {
                Console.WriteLine(item);
            }
        }
    }
}
