﻿/* ==============================================================================
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
            doc.Load("Books.xml");

            //#6.2.获取该文档的节点
            XmlElement books = doc.DocumentElement;

        }
    }
}
