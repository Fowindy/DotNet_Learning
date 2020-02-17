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
            //02.09.可以将子类对象赋值给父类,但是将父类强转子类将有可能报异常
            Person person = new Student();
            ///<![CDATA[02.10.is和as的用法:
            ///         1.如需将父类强转子类,可以使用is和as先行判断;
            ///         2.is返回的是bool类型;
            ///         3.as返回的是对象,成功返回对象,失败返回null]]>
            if (person is Student)
            {
                Student student = (Student)person;
            }
            Student student1 = person as Student;
            if (student1 != null)//说明转换成功
            {

            }
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
        /// <param name="name"></param>
        //02.03.带一个参数的构造函数
        ///<![CDATA[02.05.带一个参数是带两个参数的子集,可以如下合并]]>
        ///<![CDATA[02.06.this的第一种用法:调一个参数的构造函数相当于调了两个参数的构造函数]]>
        public Person(string name):this(name,0)
        {
            //给Name属性赋值初始化
            //this.Name = name;
        }
        //02.04.带两个参数的构造函数
        public Person(string name,int age)
        {
            //给Name,Age属性赋值初始化
            this.Name = name;
            ///<![CDATA[02.07.this的第二种用法:this指代当前对象]]>
            this.Age = age;
        }
    }
    public class Student : Person
    {
        //02.08.如果有继承关系了,子类中调用的构造函数,实际上是调用父类中无参数的构造函数
    }
}
