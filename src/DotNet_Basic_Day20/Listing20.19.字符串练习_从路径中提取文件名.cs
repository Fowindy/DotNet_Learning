using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_19
{
    public class Program
    {
        public static void Main()
        {
            //练习6.从文件路径中提取文件名(含后缀);比如从c:\a\b.txt中提取b.txt
            string path = @"c:\a\b.txt";
#if false
            #region 方法1:字符串的方式实现
            string[] pathNew = path.Split('\\', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("文件名为:{0}",pathNew[2]);
            #endregion
#elif true
            #region 方法2:Path.GetFileName()实现
            string fileName = Path.GetFileName(path);
            Console.WriteLine("文件名为:{0}",fileName);
            #endregion
#endif
        }
    }
}
