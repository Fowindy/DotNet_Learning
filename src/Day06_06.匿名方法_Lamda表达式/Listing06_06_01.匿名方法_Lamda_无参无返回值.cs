/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月27日 星期日 22:37:49
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月27日 星期日 22:37:49
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace Fowindy.Day06_06.匿名方法_Lamda表达式.Listing06_06_01
{
    public class Listing06_06_01
    {
        /// <summary>
        /// 定义无参无返回值的委托
        /// </summary>
        public delegate void MyDel();
        public static void Main()
        {
            MyDel myDel = () => { Console.WriteLine("我的心里满是阳光，因为里面住的可爱小人是你"); };
            myDel();
        }
    }
}
