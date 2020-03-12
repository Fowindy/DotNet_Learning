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
            //path = Path.Combine(@"c:\电影", @"视频\1.txt");
            //03_GetDirectoryName_获取该文件的路径(没有文件名和后缀名)
            //path = Path.GetDirectoryName(path);
            //04_GetFileName_获取文件名(含后缀)
            //path = Path.GetFileName(path);
            //05_GetFileNameWithoutExtension_获取文件名(不含后缀)
            path = Path.GetFileNameWithoutExtension(path); 
            Console.WriteLine(path);
            //@01_c:\1.txt
            //@02_c:\电影\视频\1.txt
            //@03_c:\
            //@04_1.exe
            //@05_1
            Console.ReadKey();
        }
    }
}
