﻿/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2019年11月27日 星期三 13:09:18
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.DotNet_Basic_Day22.Listing22_07
{
    public class Listing22_07
    {
        public static void Main()
        {
            //#7.1.创建xml实例对象并加载xml文档
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("Order.xml");
        }
    }
}
