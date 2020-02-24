/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月25日 星期二 06:32:22
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Day03_06.文件流读文件
{
    public class Program
    {
        static void Main(string[] args)
        {
            string msg = "锄禾日当午,地雷埋下土,老马走过去,炸成二百五";
            //01_将字符串转换成字节数组
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(msg);
            //02_将字节数组转换成字符串
            string str = System.Text.Encoding.UTF8.GetString(buffer);

            //03_通过流的方式将字符串写入文本中
            //03_01_创建一个文件流对象_文件生成路径_文件模式_文件读写方式
            FileStream fileStream = new FileStream("../../../相关资料/1.txt",FileMode.Create,FileAccess.Write);
            //03_02_调用文件流写入方法_字节数组方式_从0开始读取_读取字节数组长度
            fileStream.Write(buffer, 0, buffer.Length);
            //03_03_清除缓冲区_写入之后再内存中只有清除才能写入文本中
            fileStream.Flush();
            //03_04_关闭文件流对象
            fileStream.Close();
            //03_05_释放文件流空间
            fileStream.Dispose();
            //03_06_提示用户写入文本成功
            Console.WriteLine("写入成功!!!");

            //04_通过流的方式将字符串写入文本中_使用Using便捷释放空间_推荐
            string msg2 = "一条大河向东流";
            byte[] buffer2 = System.Text.Encoding.UTF8.GetBytes(msg2);
            using (FileStream fileStream2 = new FileStream("../../../相关资料/1.txt",FileMode.Create,FileAccess.Write))
            {
                fileStream2.Write(buffer2,0,buffer2.Length);
            }
            Console.WriteLine("写入文件2成功!!!");
            Console.ReadKey();

            //05_通过文件流的方式读取文件内容_文件生成路径_文件模式_文件读写方式
            using (FileStream fileStream3 = new FileStream("../../../相关资料/1.txt",FileMode.Open,FileAccess.Read))
            {
                //05_01_创建字节数组缓存区接收读取内容
                byte[] buffer3 = new byte[fileStream3.Length];
            }
        }
    }
}
