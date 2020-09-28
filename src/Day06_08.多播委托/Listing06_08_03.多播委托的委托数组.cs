/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月28日 星期一 11:43:37
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月28日 星期一 11:43:37
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace Fowindy.Day06_08.多播委托.Listing06_08_03
{

    public delegate int MyDel();
    public class Listing06_08_03
    {
        public static void Main()
        {
            MyDel myDel = M1;
            myDel += M2;
            myDel += M3;
            myDel -= M3;
            Delegate[] des = myDel.GetInvocationList();
            //多播委托数组的遍历
            foreach (Delegate item in des)
            {
                Console.WriteLine(item.DynamicInvoke());//1,2
            }
        }
        public static int M1()
        {
            return 1;
        }
        public static int M2()
        {
            return 2;
        }
        public static int M3()
        {
            return 3;
        }
    }
}
