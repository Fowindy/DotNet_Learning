/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月24日 星期四 12:07:56
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月24日 星期四 12:07:56
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace Fowindy.Day04_08.XML.Listing04_08_01
{
    public class Listing04_08_01
    {
        public static void Main()
        {
            //xml文件存储的位置
            string path = @"..\..\..\相关资料\XML文件案例.xml";
            //实例化xml对象加载文件---using System.Xml.Linq;
            XDocument xml = XDocument.Load(path);
            //获取xml的根元素(相当于整个xml内容)
            Console.WriteLine(xml.Root);
            Console.WriteLine("---------------------------------");
            //实例化根元素
            XElement xele = xml.Root;
            //获取根元素的名字
            Console.WriteLine(xele.Name);//school
            Console.WriteLine("---------------------------------");
            //获取根元素下第一级所有子元素
            IEnumerable<XElement> xeles =  xele.Elements();
            foreach (XElement eleClass in xeles)
            {
                Console.WriteLine(eleClass.Name);//class1   class2
                foreach (XElement eleStudent in eleClass.Elements())
                {
                    //获取class元素下student元素的名字
                    Console.WriteLine(eleStudent.Name);
                    //获取class元素下student元素的属性id值
                    Console.WriteLine(eleStudent.Attribute("id").Value);
                    //获取class元素下student元素下name元素的值
                    Console.WriteLine(eleStudent.Element("name").Value);
                    //获取class元素下student元素下gender元素的值
                    Console.WriteLine(eleStudent.Element("gender").Value);
                    //获取class元素下student元素下age元素的值
                    Console.WriteLine(eleStudent.Element("age").Value);
                }
                Console.WriteLine("---------------------------------");
            }
        }
    }
}
