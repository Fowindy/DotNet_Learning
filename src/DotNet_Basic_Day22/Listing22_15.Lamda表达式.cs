/* ==============================================================================
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

            ///<![CDATA[5.第三种:有参数有返回值的Lamda表达式调用和匿名函数调用]]>
            DelThree delThree = (string name) => { return name; };//delegate (string name) { return name; };

            ///<![CDATA[6.案例1:移除集合中大于4的元素后打印集合]]>
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            ///<![CDATA[分析:采用RemoveAll方法+委托解决]]>
            list.RemoveAll(n => n > 4);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
