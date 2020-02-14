﻿/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月14日 星期五 17:12:03
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.DotNet_Basic_Day22.Listing22_15
{
    /// <summary>
    /// 1.声明三种类型的委托
    /// </summary>
    ///<![CDATA[第一种:无参数无返回值]]>
    public delegate void DelOne();
    ///<![CDATA[第二种:有参数无返回值]]>
    public delegate void DelTwo(string name);
    ///<![CDATA[第三种:有参数有返回值]]>
    public delegate string DelThree(string name);
    public class Listing22_15
    {
        public static void Main()
        {
            ///<![CDATA[2.第一种:无参数无返回值的匿名函数调用]]>
            //DelOne delOne = delegate () { };

            ///<![CDATA[3.第一种:无参数无返回值的Lamda表达式调用]]>
            DelOne delOne = () => { };

            ///<![CDATA[4.第二种:有参数无返回值的Lamda表达式调用和匿名函数调用]]>
            DelTwo delTwo = (string name) => { };//delegate(string name){ };
        }
    }
}
