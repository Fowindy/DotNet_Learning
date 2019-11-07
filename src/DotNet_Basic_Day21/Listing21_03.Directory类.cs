﻿/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2019年11月7日 星期四 13:00:28
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace Fowindy.DotNet_Basic_Day21.Listing21_03
{
    public class Listing21_03
    {
        public static void Main()
        {
            #region $3.1.CreateDirectory:创建文件夹
            Directory.CreateDirectory(@"C:\Users\Administrator\Desktop\文件夹");
            File.Create(@"C:\Users\Administrator\Desktop\文件夹\new.txt");
            Console.WriteLine("OK");
            #endregion
            
            #region $3.3.Move:移动文件夹
            Directory.Move(@"C:\Users\Administrator\Desktop\文件夹", @"C:\Users\Administrator\Desktop\文件夹2");
            #endregion

            #region $3.2.2.Delete:删除文件夹(目录不为空不异常,永久删除)
            Directory.Delete(@"C:\Users\Administrator\Desktop\文件夹2", true);
            #endregion
        }
    }
}
