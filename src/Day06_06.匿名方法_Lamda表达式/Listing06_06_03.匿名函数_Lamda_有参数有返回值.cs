/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月27日 星期日 22:44:52
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月27日 星期日 22:44:52
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace Fowindy.Day06_06.匿名方法_Lamda表达式.Listing06_06_03
{
    public class Listing06_06_03
    {
        public delegate int MyDel(int num1, int num2);
        public static void Main()
        {
            MyDel myDel = (int num1, int num2) => { return num1 - num2; };
            int result = myDel(15, 25);
            Console.WriteLine(result);
        }
    }
}
