/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月18日 星期二 19:25:49
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day02_06.字符串的特性
{
    public class Program
    {
        static void Main(string[] args)
        {
            //01_字符串的不可变性
            string str = "床前明月光";
            //01_01_想改变字符串中的某一个字符_不可行_因为字符串是只读的
            //str[2] = "阴";
            Console.WriteLine(str[2]);//明//字符串是只读的
            //01_02_这是重新赋值不是改变字符串
            str = "低头思故乡";
            //01_03_大量字符串拼接案例_次方增长爆内存
            for (int i = 0; i < 27; i++)
            {
                str += str;//----大量字符串拼接
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
