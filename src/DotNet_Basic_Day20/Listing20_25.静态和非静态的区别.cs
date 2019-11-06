/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2019年11月6日 星期三 12:57:15
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_25
{
    public class Listing20_25
    {
        public static void Main()
        {
            /*
             *静态与非静态
             * 1.静态需要使用关键字static标识;非静态不要static关键字;
             * 2.静态成员使用类名调用;非静态成员使用实例对象调用;
             * 3.在静态方法中可以访问静态成员;在实例方法中:可以直接访问静态成员;
             * 4.在静态方法中不可以直接访问实例成员;在实例方法中:可以直接访问实例成员;
             * 5.静态:调用前初始化;非静态:实例化对象的时候初始化;
             */
        }
    }

    public class Person
    {
        //对于非静态类而言,既可以写静态成员,也可以写非静态成员;
        private static string _gender;
        private int _age;
    }
    public static class Student
    {
        //对于静态类而言,只能写静态成员;
        private static string _name;
    }
}
