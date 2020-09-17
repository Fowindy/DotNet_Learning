/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月17日 星期四 11:09:40
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月17日 星期四 11:09:40
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;

namespace Fowindy.Day04_03.正则表达式.Listing04_03_02
{
    public class Listing04_03_02
    {
        public static void Main()
        {
            //完美身份证号码18位格式验证+闰年月份判断(1900-2099)
            Console.Write("请输入您的身份证号码:");
            string date = Console.ReadLine();
            bool result;
            int.TryParse(date.Substring(6, 4), out int year);
            //闰年判断
            if ((year % 4 == 0) && (year % 400 != 0))
            {
                result = Regex.IsMatch(date, @"^[1-9][0-9]{5}(19|20)\d{2}(((01|03|05|07|08|10|12)([0-2][0-9])|(01|03|05|07|08|10|12)(3[0-1]))|((04|06|09|11)([0-2][0-9])|(04|06|09|11)(30))|(02([0-1][0-9])|(022[0-9])))\d{3}[0-9|X]$");
            }
            else
            {
                result = Regex.IsMatch(date, @"^[1-9][0-9]{5}(19|20)\d{2}(((01|03|05|07|08|10|12)([0-2][0-9])|(01|03|05|07|08|10|12)(3[0-1]))|((04|06|09|11)([0-2][0-9])|(04|06|09|11)(30))|(02([0-1][0-9])|(022[0-8])))\d{3}[0-9|X]$");
            }
            if (result)
                Console.WriteLine("身份证格式OK!");
            else
                Console.WriteLine("身份证格式错误,请确认!");
        }
    }
}
