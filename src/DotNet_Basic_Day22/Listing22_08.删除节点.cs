/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2019年12月3日 星期二 15:03:35
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.DotNet_Basic_Day22.Listing22_08
{
    public class Listing22_08
    {
        public static void Main()
        {
            //创建xml对象
            XmlDocument xmlDocument = new XmlDocument();
            //加载xml
            xmlDocument.Load("Order.xml");
            //获取单个目标节点
            XmlNode xmlNode = xmlDocument.SelectSingleNode("/Order/Items");
            //删除目标节点下的所有属性(删除目标节点)
            xmlNode.RemoveAll();
            //再保存
            xmlDocument.Save("Order.xml");
        }
    }
}
