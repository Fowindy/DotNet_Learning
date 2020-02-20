/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月20日 星期四 02:28:26
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day02_09.判断用户输入的是否是邮箱
{
    public class Program
    {
        static void Main(string[] args)
        {
            //练习1:判断用户输入的是否是邮箱
            //01_人机交互_请用户输入邮箱
            Console.Write("请您输入您的邮箱:");
            string email = Console.ReadLine();
            //fowindy_wang@hostargroup.com
            //02_判断邮箱格式_先满足有@和.号
            if (email.Contains('@') && email.Contains('.'))
            {
                Console.WriteLine("邮箱格式正确");
            }
            else
            {
                Console.WriteLine("对不起!您输入的邮箱有错误,请查证后再输入");
            }
            Console.ReadKey();
        }
    }
}
