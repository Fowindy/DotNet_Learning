/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2019年11月15日 星期五 11:51:18
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.DotNet_Basic_Day22.Listing22_03
{
    public class Listing22_03
    {
        public static void Main()
        {
            //$3.1.代码创建xlm文档
            //$3.1.1.创建xml实例对象
            XmlDocument doc = new XmlDocument();
            //$3.1.2.加入声明行
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            //$3.1.3.把声明行添加到doc中
            doc.AppendChild(dec);
            //$3.1.4.创建根节点
            XmlElement Books = doc.CreateElement("Books");
            //$3.1.5.把根节点添加到doc中
            doc.AppendChild(Books);

        }
    }
}
