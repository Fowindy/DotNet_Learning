/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2019年11月6日 星期三 16:41:13
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_26
{
    public class Listing20_26
    {
        public static void Main()
        {
            /*
             * 结构和类的区别:
             * 1.从类型来看:
             * 结构:属于值类型,值分配在内存的栈上;
             * 类:属于引用类型,值分配在内存的堆上;
             * 
             * 2.从声明语法来看:
             * 结构:struct
             * 类:class
             * 
             */
        }
    }
    //类
    public class PersonClass
    {
        //可以写:字段,属性,方法,构造函数
    }

    //结构
    public struct PersonStruct
    {
        //可以写:字段,属性
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }

        private int _age;

        public char Gender { get; set; }
        //在结构中可以写静态函数
        public static void M1()
        {
            Console.WriteLine("我是结构中的静态方法");
        }
        public void M2()
        {
            Console.WriteLine("我是结构中的非静态方法");
        }
    }
}
