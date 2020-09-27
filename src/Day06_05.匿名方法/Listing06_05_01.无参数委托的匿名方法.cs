/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月27日 星期日 20:42:01
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月27日 星期日 20:42:01
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace Fowindy.Day06_05.匿名方法.Listing06_05_01
{
    /// <summary>
    /// 定义一个无参无返回值的委托
    /// </summary>
    public delegate void MyDel();
    public class Listing06_05_01
    {
        public static void Main()
        {
            //在静态方法里面,委托可以不为静态,但实例方法必须为静态
            MyDel myDel = Show;
            myDel();

            Console.WriteLine("----------------更改为匿名方法----------------");
            //匿名方法相当于把实例方法中的"public static void Show"更改为"delegate"后合成,最后大括号后面加分号
            myDel = delegate () { Console.WriteLine("枫叶缓缓落,我只在乎你"); };
            myDel();
        }
        /// <summary>
        /// 定义实例方法
        /// </summary>
        public static void Show()
        {
            Console.WriteLine("微风轻轻起,我好喜欢你");
        }
    }
}
