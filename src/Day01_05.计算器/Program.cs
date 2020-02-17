/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月17日 星期一 10:10:20
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
///<![CDATA[04.添加引用Day01_05_Lib_Calculate.dll以及导入命名空间]>
using Day01_05_Lib_Calculate;

namespace Day01_05.计算器
{
    public class Program
    {
        static void Main(string[] args)
        {
            ///<![CDATA[01.话题引出:控制台形式的计算器]]>
            Console.Write("请输入第一个数:");
            int num1 = Convert.ToInt32(Console.ReadLine());//可能会报异常
            Console.Write("请输入第二个数:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入一个操作符(+,-,*,/):");
            string opt = Console.ReadLine();//符号
            int result = 0;
            switch (opt)
            {
                case "+":result = num1 + num2;break;
                case "-":result = num1 - num2;break;
                case "*":result = num1 * num2;break;
                case "/":result = num1 / num2;break;
            }
            Console.WriteLine("{0}{1}{2}={3}",num1,opt,num2,result);
            Console.ReadKey();
        }
    }
}
