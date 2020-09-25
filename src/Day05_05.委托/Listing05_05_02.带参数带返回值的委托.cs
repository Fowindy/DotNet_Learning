/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月26日 星期六 06:51:22
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月26日 星期六 06:51:22
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace Fowindy.Day05_05.委托.Listing05_05_02
{
    public class Listing05_05_02
    {
        /// <summary>
        /// 委托(根据Add方法中的参数和返回值定义的)
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public delegate int MyDel(int num1, int num2);
        public static void Main()
        {
            //[?1].为什么在Add方法中能实现的方法要放到Calc方法中委托执行呢?
            int result = Calc(Add, 34, 68);
            Console.WriteLine(result);
        }
        public static int Calc(MyDel myDel,int num1,int num2)
        {
            return myDel(num1, num2);
        }
        public static int Add(int num1,int num2)
        {
            return num1 + num2;
        }
    }
}
