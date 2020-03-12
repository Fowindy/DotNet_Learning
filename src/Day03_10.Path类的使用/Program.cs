/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年3月12日 星期四 08:07:26
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Day03_10.Path类的使用
{
    public class Program
    {
        static void Main(string[] args)
        {
            //01_ChangeExtension更改路径字符串的后缀名
            string path = @"c:\1.exe";
            path = Path.ChangeExtension(path, ".txt");
            Console.WriteLine(path);
            Console.ReadKey();
        }
    }
}
