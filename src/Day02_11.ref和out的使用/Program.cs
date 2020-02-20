/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月20日 星期四 15:16:21
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day02_11.ref和out的使用
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = 1000;
            //02_此时调用Add方法_但因为方法作用域的原因_对Main方法并没有影响
            Add(num);
            Console.WriteLine(num);//1000
            Console.ReadKey();  
        }
        //01_声明一个Add方法
        public static void Add(int n1)
        {
            n1 = 100;
        }
    }
}
