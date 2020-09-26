/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月26日 星期六 08:21:18
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月26日 星期六 08:21:18
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace Fowindy.Day05_05.委托.Listing05_05_04
{
    public class Listing05_05_04
    {
        public delegate void MyDel();
        public static void Main()
        {
            //委托预留处---插入时间
            //DoSomthing(InsertTime);
            //委托预留处---存储时间
            DoSomthing(SaveTime);
        }
        public static void InsertTime()
        {
            Console.WriteLine(System.DateTime.Now.ToString());
        }
        public static void SaveTime()
        {
            File.WriteAllText("DateTime.txt", System.DateTime.Now.ToString());
        }
        public static void DoSomthing(MyDel myDel)
        {
            Console.WriteLine("明天行程安排:");
            Console.WriteLine("7:00---起床");
            Console.WriteLine("8:00---去公司");
            Console.WriteLine("9:00---开会");
            #region 10:00是未安排的,需要通过委托后面安排
            myDel();
            #endregion
            Console.WriteLine("12:00---吃中饭");
            Console.WriteLine("17:00---下班");
            Console.WriteLine("16:00---吃晚饭");
        }
    }
}
