/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月26日 星期六 08:34:54
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月26日 星期六 08:34:54
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace Fowindy.Day05_05.委托.Listing05_05_05
{
    public delegate string MyDel(string name);
    public class Listing05_05_05
    {
        public static void Main()
        {
            //1.声明一个目标字符串数组
            string[] names = new string[] { "Apple", "Pear", "Peach", "Grape" };
            //2.声明一个字符串操作的方法
            ChangeStr(strToUpper, names);
            ChangeStr(strInsertChar, names);
        }
        /// <summary>
        /// 字符插入间隔符
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private static string strInsertChar(string name)
        {
            return "=" + name + "=";
        }

        /// <summary>
        /// 字符转大写
        /// </summary>
        /// <param name="name">字符</param>
        /// <returns></returns>
        private static string strToUpper(string name)
        {
            return name.ToUpper();
        }

        private static void ChangeStr(MyDel myDel, string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = myDel(names[i]);
                Console.WriteLine(names[i]);
            }
        }
    }
}
