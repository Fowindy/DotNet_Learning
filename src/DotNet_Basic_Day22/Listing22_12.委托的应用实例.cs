/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月13日 星期四 21:13:17
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.DotNet_Basic_Day22.Listing22_12
{
    /// <summary>
    /// 声明委托类型
    /// </summary>
    /// <param name="name"></param>
    public delegate void DelSayHi(string name);
    public class Listing22_12
    {
        public static void Main()
        {
            ///<![CDATA[第一种调用方式:函数赋值给委托]]>
            SayHi("张三", SayHiChinese);
        }

        ///<![CDATA[把函数传进来需要声明委托类型]]>
        public static void SayHi(string name, DelSayHi delSayHi)
        {
            delSayHi(name);
        }


        public static void SayHiChinese(string name)
        {
            Console.WriteLine("你好," + name);
        }

        public static void SayHiEnglish(string name)
        {
            Console.WriteLine("Hello," + name);
        }
    }
}
