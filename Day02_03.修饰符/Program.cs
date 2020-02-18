/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月18日 星期二 15:28:45
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day02_03.修饰符
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
    //01_声明一个Person类并定义字段
    public class Person
    {
        string _name;
    }
    //02_声明一个Student类并继承Person类
    public class Student:Person
    {
        public void Say()
        {

        }
    }
}
