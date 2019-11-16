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

            //$3.1.7.给Books添加子节点Book1
            XmlElement Book1 = doc.CreateElement("Book1");
            Books.AppendChild(Book1);
            //@3.1.7.1.给Book1添加名字属性节点
            XmlElement Name1 = doc.CreateElement("Name1");
            Name1.InnerText = "金瓶梅";
            Book1.AppendChild(Name1);
            //@3.1.7.2.给Book1添加价格属性节点
            XmlElement Price1 = doc.CreateElement("Price1");
            Price1.InnerText = "10";
            Book1.AppendChild(Price1);
            //@3.1.7.3.给Book1添加描述属性节点
            XmlElement Des1 = doc.CreateElement("Des1");
            Des1.InnerText = "好看,不解释";
            Book1.AppendChild(Des1);

            //$3.1.8.给Books添加子节点Book2
            XmlElement Book2 = doc.CreateElement("Book2");
            Books.AppendChild(Book2);
            //@3.1.8.1.给Book2添加名字属性节点
            XmlElement Name2 = doc.CreateElement("Name2");
            Name2.InnerText = "水浒传";
            Book2.AppendChild(Name2);
            //@3.1.8.2.给Book2添加价格属性节点
            XmlElement Price2 = doc.CreateElement("Price2");
            Price2.InnerText = "90";
            Book2.AppendChild(Price2);
            //@3.1.8.3.给Book2添加描述属性节点
            XmlElement Des2 = doc.CreateElement("Des2");
            Des2.InnerText = "108个拆迁户";
            Book2.AppendChild(Des2);

            //$3.1.6.保存xml文档
            doc.Save("Books.xml");
            Console.WriteLine("保存成功");
        }
    }
}
