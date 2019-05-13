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
        }
    }

    public class Person
    {
        //1_2-1.name自动属性
        public string Name { get; set; }
        //1_2-2.age自动属性
        public int Age { get; set; }

        //1_1.无参的构造函数
        public Person()
        {

        }
        //1_2.有一个参数的构造函数
        public Person(string name)
        {
            this.Name = name;
        }
        //1_3.两个参数的构造函数
        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
