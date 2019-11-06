/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2019年11月6日 星期三 20:12:11
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Fowindy.DotNet_Basic_Day21.Listing21_01
{
    public class Listing21_01
    {
        public static void Main()
        {
            #region $1.1.ChangeExtension方法:修改文件的后缀，“修改”支持字符串层面的，没有真的给文件改名
            string path = @"J:\Documents\学习笔记\文档\应用程序临时文件路径更改.txt";
            Console.WriteLine(Path.ChangeExtension(path, "jpg"));
            #endregion

            #region $1.2.Combine方法:将两个路径合成一个路径，比用+好，可以方便解决不加斜线的问题
            string s = Path.Combine(@"c:\temp", "a.jpg");
            Console.WriteLine(s);//c:\temp\a.jpg
            #endregion
        }
    }
}
