/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月25日 星期二 06:32:22
 * ==============================================================================*/
using System;
using System.Collections.Generic;
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
        }
    }
}
