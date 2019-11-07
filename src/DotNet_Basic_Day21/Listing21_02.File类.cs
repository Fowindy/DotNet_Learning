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
            #region $2.1.文件的创建
            using (File.Create(@"C:\Users\Administrator\Desktop\new.txt"))
            {
                Console.WriteLine("创建成功");
            }
            #endregion

            #region $2.2.文件的删除
            File.Delete(@"C:\Users\Administrator\Desktop\new.txt");
            Console.WriteLine("删除成功");
            #endregion

            #region $2.3.文件的复制
            File.Copy(@"J:\Documents\学习笔记\文档\Program_Prefect.cs", @"C:\Users\Administrator\Desktop\new.txt");
            #endregion

            #region $2.4.文件的剪切
            File.Move(@"C:\Users\Administrator\Desktop\new.txt", @"C:\Users\Administrator\Desktop\old.txt");
            #endregion

            #region $2.5.File类读取文件

            #endregion
        }
    }
}
