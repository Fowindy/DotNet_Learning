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
            //04_传进ref之前必须进行变量初始化_ref可进可出_可以往通过ref将值传进方法也可以通过ref带出来
            int num = 1000;
            //02_此时调用Add方法_但因为方法作用域的原因_对Main方法并没有影响
            //03_Add方法加入ref参数后_对Main函数有影响_ref可进可出_ref传进的是变量的值在栈空间对应的地址
            Add(ref num);
            Console.WriteLine(num);//100//1000
            Console.ReadKey();  
        }
        //01_声明一个Add方法
        public static void Add(ref int n1)
        {
            n1 = 100;
        }
    }
}
