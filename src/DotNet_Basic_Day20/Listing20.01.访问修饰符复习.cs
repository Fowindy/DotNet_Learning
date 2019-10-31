using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_01
{
    public class Person
    {
        protected string _name;
        public void T()
        {
            Console.WriteLine("父类方法");
        }
    }

    //注意2:子类的访问权限不能高于父类的访问权限;
    public class Teacher : Person
    {
        //子类存在和父类同名的方法；子类将会屏蔽父类的方法；
        public new void T()
        {
            Console.WriteLine("子类方法");
            //子类中可以访问父类protected修饰的成员
            _name = "子类可以访问";
        }
    }
    public class Program
    {
        public static void Main()
        {
            //note1.需要注意的关键字this和new
            ///<![CDATA[this的作用
            ///&作用1:指代当前类的对象;
            ///&作用2:调用自己的构造函数;]]>
            ///

            ///<![CDATA[new的作用:
            ///&作用1:创建对象;
            ///&作用2:隐藏父类的成员;举例说明]]>
            ///

            Teacher teacher = new Teacher();
            teacher.T();//父类的方法

            //在其他类里面不能访问到
        }
    }
}
