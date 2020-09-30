/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月27日 星期日 22:18:27
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月27日 星期日 22:18:27
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace Fowindy.Day06_05.匿名方法.Listing06_05_02
{
    /// <summary>
    /// 定义有参数无返回值的委托
    /// </summary>
    /// <param name="str"></param>
    public delegate void MyDel(string str);
    public class Listing06_05_02
    {
        public static void Main()
        {
            //有参数无返回值匿名方法的调用
            MyDel myDel = delegate (string str) { Console.WriteLine(str); };
            myDel("喜欢你，春夏秋冬的喜欢。");
            myDel("多喝热水早点睡，多穿衣服盖好被");
        }
    }
}
