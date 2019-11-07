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
            File.Delete(@"C:\Users\Administrator\Desktop\old.txt");
            Console.WriteLine("删除成功");
            #endregion

            #region $2.3.文件的复制
            File.Copy(@"J:\Documents\学习笔记\文档\Program_Prefect.cs", @"C:\Users\Administrator\Desktop\new.txt");
            #endregion

            #region $2.4.文件的剪切
            File.Move(@"C:\Users\Administrator\Desktop\new.txt", @"C:\Users\Administrator\Desktop\old.txt");
            #endregion

            #region $2.5.File类读取文件
            #region @2.5.1.File类读取文件_ReadAllBytes:以字节的形式读取;
            byte[] buffer = File.ReadAllBytes(@"C:\Users\Administrator\Desktop\old.txt");
            //将读取到的字节数组按指定的解码方式解码成字符串
            string str = Encoding.Default.GetString(buffer, 0, buffer.Length);//解码buffer,从第0个开始解码buffer.Length长度
            ///<![CDATA[Encoding.Default:采取什么编码来读取
            ///编码:把字符串以怎样的形式存储为二进制;ASCII,GBK,GB2312,UTF-8]]>
            Console.WriteLine(str);
            #endregion

            #region @2.5.2.File类读取文件_ReadAllLines:以行读取
            string[] strNew = File.ReadAllLines(@"C:\Users\Administrator\Desktop\old.txt",Encoding.Default);
            for (int i = 0; i < strNew.Length; i++)
            {
                Console.WriteLine(strNew[i]);
            }
            #endregion

            #region @2.5.3.File类读取文件_ReadAllText:读取文件并关闭文件
            string str1 = File.ReadAllText(@"C:\Users\Administrator\Desktop\old.txt", Encoding.Default);
            Console.WriteLine(str);
            #endregion
            #endregion

            #region $2.6.File类写入文件
            string str2 = "今天是最后一天复习了";
            //把需要写入的字符串解码成字节数组
            byte[] buffer1 = Encoding.Default.GetBytes(str2);
            #region @2.6.1.WriteAllBytes:以字节写入(覆盖)
            File.WriteAllBytes(@"C:\Users\Administrator\Desktop\old.txt", buffer1);
            #endregion
            #endregion
        }
    }
}
