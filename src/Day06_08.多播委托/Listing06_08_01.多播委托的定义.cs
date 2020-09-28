/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月28日 星期一 10:47:03
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月28日 星期一 10:47:03
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace Fowindy.Day06_08.多播委托.Listing06_08_01
{
    public delegate void MyDel();
    public class Listing06_08_01
    {
        public static void Main()
        {
            //多播委托可以进行加减方法
            MyDel myDel = M1;
            myDel += M2;
            myDel += M3;
            myDel -= M2;
            myDel();//1,3
        }
        public static void M1()
        {
            Console.WriteLine("1");
        }
        public static void M2()
        {
            Console.WriteLine("2");
        }
        public static void M3()
        {
            Console.WriteLine("3");
        }
        public static void M4()
        {
            Console.WriteLine("4");
        }
    }
}
