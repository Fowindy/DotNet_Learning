/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2019年11月27日 星期三 11:05:39
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.DotNet_Basic_Day22.Listing22_06
{
    public class Listing22_06
    {
        public static void Main()
        {
            //#6.1创建xml对象,并加载xml文档
            XmlDocument doc = new XmlDocument();
            doc.Load("Books1.xml");

            //#6.2.获取该文档的节点
            XmlElement books = doc.DocumentElement;

            //#6.3.获取该节点的所有子节点
            XmlNodeList xmlNodeList = books.ChildNodes;

            //#6.4.遍历读取所有子节点的属性并打印输出
            int index;
            foreach (XmlNode item in xmlNodeList)
            {
                Console.WriteLine(item.InnerText);
                XmlNodeList itemList = item.ChildNodes;
                index = 0;
                //@6.4.1.遍历读取所有子节点单项属性并打印输出
                foreach (XmlNode itemChild in item)
                {
                    if (index == 0)
                    {
                        Console.WriteLine(itemChild.InnerText);
                    }
                    index++;
                }
            }
        }
    }
}
