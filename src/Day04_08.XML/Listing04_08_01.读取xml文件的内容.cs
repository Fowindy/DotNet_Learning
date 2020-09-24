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
        }
    }
}
