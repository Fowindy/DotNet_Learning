/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2019年11月7日 星期四 16:43:03
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Fowindy.DotNet_Basic_Day21.Listing21_05
{
    public class Listing21_05
    {
        public static void Main()
        {
            #region $5.1.文件流类有三个:FileStream,StreamReader,StreamWriter 
            //FileStream:操作字节(必须掌握)
            //StreamReader/StreamWriter:操作字符

            //using自动释放文件流资源
            #region @5.1.1.文件流读取文件
            using (FileStream fsRead = new FileStream(@"J:\Documents\学习笔记\文档\应用程序临时文件路径更改.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                //建立单次最大读取的字节缓存区,为避免崩溃,每次最大读取5M
                byte[] buffer = new byte[1024 * 1024 * 5];
                //实际读取到的字节数
                int r = fsRead.Read(buffer, 0, buffer.Length);
                //将字节解码成字符串
                string str = Encoding.Default.GetString(buffer, 0, r);
                Console.WriteLine(str);
            }
            #endregion

            #region @5.1.2.文件流的写入文件_FileStream
            //FileMode.Append:以追加的方式写入,不会覆盖原文件
            using (FileStream fsWrite = new FileStream(@"J:\Documents\学习笔记\文档\应用程序临时文件路径更改.txt",FileMode.Append,FileAccess.Write))
            {
                //要写入的字符串
                string str = "\n今天天气好晴朗";
                //将要写入的字符串解码成字节数组
                byte[] buffer = Encoding.Default.GetBytes(str);
                //将字节缓存写入文件
                fsWrite.Write(buffer, 0, buffer.Length);
                Console.WriteLine("写入成功");
            }
            #endregion
            #endregion
        }
    }
}
