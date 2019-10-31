using System;
using Fowindy.DotNet_Basic_Day20.Listing20_01;

namespace DotNet_Basic_Day20_20_01_Protected不同项目访问测试
{
    public class Student : Person
    {
        public new  void T()
        {
            //在不同的项目可以通过继承,访问到protected修饰的成员,但不可以访问到internal修饰的成员
            _name = "可以在不同的项目中通过继承,访问到protected修饰的成员";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //可以访问到不同项目的public修饰的成员
            Person p = new Person();
            Console.WriteLine("Hello World!");
        }
    }
}
