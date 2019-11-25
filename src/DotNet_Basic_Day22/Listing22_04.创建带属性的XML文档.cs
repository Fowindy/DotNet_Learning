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
            CustomerName.InnerText = "刘洋";
            Order.AppendChild(CustomerName);

            XmlElement OrderNumber = doc.CreateElement("OrderNumber");
            OrderNumber.InnerText = "bj0000001";
            Order.AppendChild(OrderNumber);

            XmlElement Items = doc.CreateElement("Items");

            //$4.2.创建属性子节点
            XmlElement OrderItem1 = doc.CreateElement("OrderItem");

            Items.AppendChild(OrderItem1);
            Order.AppendChild(Items);
            doc.Save("Order.xml");
        }
    }
}
