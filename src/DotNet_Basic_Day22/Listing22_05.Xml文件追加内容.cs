/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2019年11月25日 星期一 17:33:45
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Fowindy.DotNet_Basic_Day22.Listing22_05
{
    public class Listing22_05
    {
        public static void Main()
        {
            //创建xml文档实例对象
            XmlDocument doc = new XmlDocument();
            //#5.1.如果文件已经存在
            if (File.Exists("Books.xml"))
            {
            }
        }
    }
}
