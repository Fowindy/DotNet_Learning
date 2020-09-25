/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月25日 星期五 23:06:16
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月25日 星期五 23:06:16
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace Fowindy.Day05_05.委托.Listing05_05_01
{
    public class Listing05_05_01
    {
        public delegate void MyDelegate();
        public static void Main()
        {
            //委托其实就是把B方法委托成类型变量(参数)然后方便A方法传参调用,C方法调用A方法的同时可运行B方法内容
            A(B);
        }
        public static void A(MyDelegate mdl)
        {
            mdl();
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("前路漫漫雨纷飞");
            }
        }
        public static void B()
        {
            for (int i = 0;i<50;i++)
            {
                Console.WriteLine("床前明月光,地上鞋两双");
            }
        }
    }
}
