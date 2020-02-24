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
        }
    }
}
