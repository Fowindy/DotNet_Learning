/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月24日 星期一 09:43:08
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.Day03_04.集合作业练习.Listing04_01
{
    public class Listing04_01
    {
        public static void Main()
        {
            //01_接收用户输入的日期
            Console.Write("请您输入日期(如二零一二年三月二日):");
            string strDate = Console.ReadLine();
            //02_调用方法转换成数字类型的日期
            string date = GetNumberByStrDate(strDate);
            //03_打印并输出数字日期结果
            Console.WriteLine(date);
        }

        private static string GetNumberByStrDate(string strDate)
        {
            throw new NotImplementedException();
        }
    }
}
