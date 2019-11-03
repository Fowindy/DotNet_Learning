using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_15
{
    public class Program
    {
        public static void Main()
        {
            //课上练习2:遍历输出用户输入的字符串中的每一个字符
            Console.Write("请输入字符串:");
            string str = Console.ReadLine();
            //首先创建char类型的数组
            char[] chs = new char[str.Length];
            //用for循环给字符数组中的每一个元素赋值
            for (int i = 0; i < str.Length; i++)
            {
                chs[i] = str[i];
            }
            //遍历输出字符数组中的每一个字符
            foreach (var item in chs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
