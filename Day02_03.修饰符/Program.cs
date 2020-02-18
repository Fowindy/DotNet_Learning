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
        //02_02_字段的默认访问修饰符是private私有的,只能在本类中访问
        //private string _name;
        //如果变成protected
        //protected string _name;
        //如果变成public
        public string _name;
    }
    //02_声明一个Student类并继承Person类
    public class Student:Person
    {
        public void Say()
        {
            //02_01_在子类中无法调用到父类中默认字段(字段的默认访问修饰符为:private)
            //02_03_protected访问修饰符,在本类和子类中可以访问
            //02_04_public访问修饰符任何地方都可以访问
            this._name = "张三";
            base._name = "李四";
        }
    }
}
