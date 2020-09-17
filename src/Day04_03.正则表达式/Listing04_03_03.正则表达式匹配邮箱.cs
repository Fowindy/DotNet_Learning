/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月17日 星期四 13:10:17
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月17日 星期四 13:10:17
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;

namespace Fowindy.Day04_03.正则表达式.Listing04_03_03
{
    public class Listing04_03_03
    {
        //正则表达式验证邮箱格式
        public static void Main()
        {
            Console.Write("请输入您的电子邮箱:");
            if (Regex.IsMatch(Console.ReadLine(), @"[0-9a-zA-Z_.-]+@[0-9a-zA-Z_.-]+([.][a-zA-Z]+){1,2}"))
                Console.WriteLine("邮箱输入正确!");
            else
                Console.WriteLine("邮箱格式错误!请确认!");
        }
    }
}
