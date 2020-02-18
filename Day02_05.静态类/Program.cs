/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月18日 星期二 16:56:03
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day02_05.静态类
{
    public class Program
    {
        static void Main(string[] args)
        {
            //01_静态类为什么不能被实例化
            //Console console = new Console();
            //01_01_静态类可以看成是抽象(abstract)的密封(sealed)类,密封类不能被继承
            //01_02_string是密封类,密封类可以实例化
            string s = new string("");
            //01_04_静态类是抽象类和密封类的综合类_静态类不能实例化也不能被继承
            //01_05_C#中没有全局变量_但可以通过静态字段模拟全局变量
        }
    }
    //01_03_string是密封类不能被继承
    //public class Person:String
    //{

    //}
}
