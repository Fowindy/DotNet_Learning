/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年3月12日 星期四 09:04:39
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Day03_11.Directory类的使用
{
    public class Program
    {
        static void Main(string[] args)
        {
            //01_CreateDirectory_在该目录下创建一个文件夹
            Directory.CreateDirectory(@"../../../相关资料/1");
        }
    }
}
