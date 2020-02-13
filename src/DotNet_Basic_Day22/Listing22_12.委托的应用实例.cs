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
            ///<![CDATA[第四种调用方式:采用Lamda表达式_第三种方法的补充_强力推介]]>
            DelSayHi delSayHi4 = (string name) => { Console.WriteLine("你好," + name); };
            delSayHi4("张三");
        }
    }
}
