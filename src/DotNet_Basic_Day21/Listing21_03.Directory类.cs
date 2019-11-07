/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2019年11月7日 星期四 13:00:28
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Fowindy.DotNet_Basic_Day21.Listing21_03
{
    public class Listing21_03
    {
        public static void Main()
        {
            #region $3.1.CreateDirectory:创建文件夹
            Directory.CreateDirectory(@"C:\Users\Administrator\Desktop\文件夹");
            Console.WriteLine("OK");
            #endregion
        }
    }
}
