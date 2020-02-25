/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月25日 星期二 08:27:44
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Day03_07.复制视频文件
{
    public class Program
    {
        static void Main(string[] args)
        {
            //01_定义源路径和目标路径
            string sourcePath = "../../../相关资料/创建和客户端通信的Socket.mp4";
            string targetPath = "../../../相关资料/Socket.mp4";
            //02_创建读取文件流对象
            using (FileStream fsRead = new FileStream(sourcePath,FileMode.Open,FileAccess.Read))
            {
                //02_01_创建写入文件流对象
                using (FileStream fsWrite = new FileStream(targetPath,FileMode.Create,FileAccess.Write))
                {

                }
            }
        }
    }
}
