/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月26日 星期六 15:22:17
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月26日 星期六 15:22:17
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace Fowindy.Day06_01.委托.Listing06_01_01
{
    public class Listing06_01_01
    {
        public delegate void MyDel();
        public static void Main()
        {
            Test(Show);
        }
        /// <summary>
        /// 调用委托的方法
        /// </summary>
        /// <param name="myDel"></param>
        private static void Test(MyDel myDel)
        {
            Console.WriteLine("十一过得怎么样?");
            myDel();
            Console.WriteLine("十一过完了,收心开始工作了.");
        }
        /// <summary>
        /// 被委托的实例方法
        /// </summary>
        private static void Show()
        {
            Console.WriteLine("十一过得真不轻松!");
        }
    }
}
