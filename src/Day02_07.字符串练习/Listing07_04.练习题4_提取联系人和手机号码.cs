/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月19日 星期三 20:42:03
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Fowindy.Day02_07.字符串练习.Listing07_04
{
    public class Listing07_04
    {
        public static void Main()
        {
            //07_04_01_读取文件_重点_相对上上级路径的获取方法
            string[] lines = File.ReadAllLines("../../../相关资料/练习4.csv");
        }
    }
}