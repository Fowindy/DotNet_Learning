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
            XmlElement books;
            //#5.1.如果文件已经存在
            if (File.Exists("Books.xml"))
            {
                //@5.1.1.加载该xml文件到实例对象
                doc.Load("Books.xml");
                //@5.1.2.获取该xml文件的根节点
                books = doc.DocumentElement;

            }
            //#5.2.如果文件不存在,则创建xml文件
            else
            {
                //@5.2.1.创建描述信息
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(dec);
                //@5.2.2.创建根节点
                books = doc.CreateElement("Books");
                doc.AppendChild(books);
            }
            //@5.1.3.在该根节点上添加子节点
            XmlElement book3 = doc.CreateElement("book3");
            books.AppendChild(book3);

            XmlElement name3 = doc.CreateElement("Name3");
            name3.InnerText = "三国演义";
            book3.AppendChild(name3);

            XmlElement price3 = doc.CreateElement("Price3");
            price3.InnerText = "198";
            book3.AppendChild(price3);

            XmlElement des3 = doc.CreateElement("Des3");
            des3.InnerText = "乱世出英雄";
            book3.AppendChild(des3);

            doc.Save("Books.xml");
        }
    }
}
