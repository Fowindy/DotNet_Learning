/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2019年11月7日 星期四 00:03:37
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Fowindy.DotNet_Basic_Day21.Listing21_02
{
    public class Listing21_02
    {
        public static void Main()
        {
            //操作文件的复制,剪切,创建,移除
            #region $2.1文件的创建
            File.Create(@"C:\Users\Administrator\Desktop\new.txt");
            Console.WriteLine("创建成功");
            #endregion
        }
    }
}
