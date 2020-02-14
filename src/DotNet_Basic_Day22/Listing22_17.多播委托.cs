/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月14日 星期五 23:05:39
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.DotNet_Basic_Day22.Listing22_17
{
    ///<![CDATA[1.声明一个无参无返回值的委托]]>
    public delegate void DelTest();
    public class Listing22_17
    {
        public static void Main()
        {
            ///<![CDATA[3.调用委托实现功能]]>
            DelTest delTest = T1;
            ///<![CDATA[4.多播委托的实现]]>
            delTest += T2;
            delTest += T3;
            delTest();
        }
        ///<![CDATA[2.声明可以赋值给委托的函数]]>
        public static void T1()
        {
            Console.WriteLine("我是T1");
        }
        public static void T2()
        {
            Console.WriteLine("我是T2");
        }
        public static void T3()
        {
            Console.WriteLine("我是T3");
        }
        public static void T4()
        {
            Console.WriteLine("我是T4");
        }
    }
}
