﻿/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年3月5日 星期四 11:41:21
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Day03_09.File类的使用
{
    public class Program
    {
        static void Main(string[] args)
        {
            //01_AppendAllText_向文本中追加内容
            File.AppendAllText("../../../相关资料/1.txt","哈哈哈");
            //02_Create_创建文件_等同于FileStream对象
            File.Create("../../../相关资料/t.txt");
            //FileStream fileStream = new FileStream("../../../相关资料/t.txt", FileMode.Create, FileAccess.ReadWrite);
        }
    }
}
