/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2019年11月16日 星期六 09:20:38
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.DotNet_Basic_Day22.Listing22_04
{
    public class Listing22_04
    {
        public static void Main()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);

            XmlElement Order = doc.CreateElement("Order");
            doc.AppendChild(Order);

            XmlElement CustomerName = doc.CreateElement("CustomerName");
            //创建标签用InnerXml
            CustomerName.InnerXml = "<p>我是一个标签</p>";
            Order.AppendChild(CustomerName);

            XmlElement OrderNumber = doc.CreateElement("OrderNumber");
            //创建文本用InnerText
            OrderNumber.InnerText = "<p>我是一个标签</p>";
            Order.AppendChild(OrderNumber);

            XmlElement Items = doc.CreateElement("Items");
            Order.AppendChild(Items);

            //$4.2.创建属性子节点
            XmlElement OrderItem1 = doc.CreateElement("OrderItem");
            //#4.2.1.给子节点添加属性
            OrderItem1.SetAttribute("Name", "码表");
            OrderItem1.SetAttribute("Count", "10");
            Items.AppendChild(OrderItem1);

            XmlElement OrderItem2 = doc.CreateElement("OrderItem");
            OrderItem2.SetAttribute("Name", "雨衣");
            OrderItem2.SetAttribute("Count", "40");
            Items.AppendChild(OrderItem2);

            XmlElement OrderItem3 = doc.CreateElement("OrderItem");
            OrderItem3.SetAttribute("Name", "手套");
            OrderItem3.SetAttribute("Count", "1");
            Items.AppendChild(OrderItem3);
            doc.Save("Order.xml");
        }
    }
}
