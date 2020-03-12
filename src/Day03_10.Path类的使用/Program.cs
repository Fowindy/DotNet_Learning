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
            //path = Path.ChangeExtension(path, ".txt");
            //02_Combine合并路径的_反射的时候会使用到
            path = Path.Combine(@"c:\电影", @"视频\1.txt");
            Console.WriteLine(path);
            //01_c:\1.txt
            //02_c:\电影\视频\1.txt
            Console.ReadKey();
        }
    }
}
