/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月27日 星期日 22:41:15
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月27日 星期日 22:41:15
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace Fowindy.Day06_06.匿名方法_Lamda表达式.Listing06_06_02
{
    /// <summary>
    /// 定义有参数无返回值的委托
    /// </summary>
    /// <param name="str"></param>
    public delegate void MyDel(string str);
    public delegate string MyDel1(string str);
    public class Listing06_06_02
    {
        public static void Main()
        {
            MyDel myDel = (string str) => { Console.WriteLine(str); };
            myDel("世间情动，不过盛夏白瓷梅子汤。碎冰撞壁叮当响");
            Console.WriteLine("----------------第二种方式----------------");
            MyDel1 myDel1 = x => x + "好帅";
            Console.WriteLine(myDel1("小杨"));    //小杨好帅
        }
    }
}
