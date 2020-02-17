/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月17日 星期一 23:02:46
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day02_01.this的一种用法
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        //01.新增类不建议写(嵌套类)在主类里面
        //public class Person
        //{
        //}
    }
    //02.新增Person类
    public class Person
    {
        //02.01.定义姓名,年龄属性
        public string Name { get; set; }
        public int Age { get; set; }
        //02.02.无参构造函数
        public Person()
        {
        }
        //02.03.带一个参数的构造函数
        public Person(string name)
        {
            //给Name属性赋值初始化
            this.Name = name;
        }
        //02.04.带两个参数的构造函数
        public Person(string name,int age)
        {
            //给Name,Age属性赋值初始化
            this.Name = name;
            this.Age = age;
        }
    }
}
