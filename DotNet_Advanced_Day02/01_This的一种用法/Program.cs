using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_This的一种用法
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
        }
    }

    public class Person
    {
        //1_2-1.name自动属性
        public string Name { get; set; }
        //1_2-2.age自动属性
        public int Age { get; set; }
        //2_3.解决方法是:在父类中加入无参构造函数的声明
        public Person()
        {

        }
        //1_2.有一个参数的构造函数
        public Person(string name):this(name,0)
        {
        }
        //1_3.两个参数的构造函数
        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

    public class Student:Person
    {
        //2_1.如果无继承关系,Student调用的是自己默认的无参数的构造函数,编译不会报错
        //2_2.当有继承关系,子类调用的无参的构造函数实际是父类的无参构造函数,父类中又没有无参构造函数,所以编译报错
        //严重性	说明错误	“Person”不包含采用 0 个参数的构造函数

        //2_知识点2.如果子类继承父类,子类中调用的构造函数,实际上是调用的父类中的无参数的构造函数
    }
}
