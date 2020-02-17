﻿/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月17日 星期一 16:47:41
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Day01_06.文件案例
{
    public class Program
    {
        static void Main(string[] args)
        {
            //01.01.简单思路
            Console.Write("请您输入文件:");
            string str = Console.ReadLine();
            //获取文件的后缀名
            //判断文件的后缀名

            //01.02.实例化父类对象,并获取子类对象
            UserFile userFile = GetFileOpenTool(str);
            userFile.ShowResult();
            Console.ReadKey();  
        }
        //01.03.根据后缀给父类对象赋值对应子类对象
        private static UserFile GetFileOpenTool(string str)
        {
            UserFile userFile = null;
            switch (Path.GetExtension(str))
            {
                case ".avi": userFile = new AVIFile(str); break;
            }
            return userFile;
        }
    }
}
