/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月28日 星期一 09:51:35
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月28日 星期一 09:51:35
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace Fowindy.Day06_07.Lamda表达式_系统委托.Listing06_07_01
{
    public class Listing06_07_01
    {
        public static void Main()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            //Func是系统带参数的委托,最多有17个参数,如果委托没有返回值则使用Action有16个参数
            IEnumerable<int> ies = list.Where(x => x > 5);
            int[] nums = { 123, 456 };
            //打印nums的父类类型
            Console.WriteLine(nums.GetType().BaseType);//System.Array
            //foreach遍历公共枚举
            foreach (var item in ies)
            {
                Console.WriteLine(item);
            }
        }
    }
}
