/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月17日 星期四 10:14:06
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月17日 星期四 10:14:06
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;

namespace Fowindy.Day04_03.正则表达式.Listing04_03_01
{
    public class Listing04_03_01
    {
        public static void Main()
        {
            bool result = Regex.IsMatch("987", @"\d{3}");
            if (result)
                Console.WriteLine("匹配!");
            else
                Console.WriteLine("不匹配!");
        }
    }
}
