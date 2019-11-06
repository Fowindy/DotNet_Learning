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
             * 3.从构造函数的赋值来看:
             * 在类中:构造函数里,既可以给字段赋值,也可以给属性赋值;构造函数可以重载;
             * 在结构中:构造函数里,只能给字段赋值,不可以给属性赋值;在结构构造函数中,需要给全部的字段赋值,不能选择性的给字段赋值;也即不可以重载;
             * 
             * 4.从调用来看:
             * 类new对象的3作用:1.在堆中开辟空间;2.在开辟的堆空间中创建对象;3.调用对象的额构造函数进行初始化
             * 结构的new的1作用:调用结构的构造函数;
             * 
             * 5.从结构和类的构造函数来看:
             * 相同点:不管是结构还是类,本身都会有一个默认的无参数的构造函数;
             * 不同点1:当你在类中写了一个新的构造函数之后,那个默认的无参数的构造函数就被覆盖了;但结构中无参数的构造函数依然存在;
             * 
             * 6.从应用方面来看:
             * 如果我们只是单纯的存储数据的话,我们推荐使用结构;因为结构的空间在栈上,可以节省空间;
             * 如果我们想使用面向对象的思想来开发程序,我们推荐使用类;因为结构并没有面向对象的特征;
             */
            //类new对象的3作用:1.在堆中开辟空间;2.在开辟的堆空间中创建对象;3.调用对象的额构造函数进行初始化
            PersonClass personClass = new PersonClass();

            //结构是否可以new?可以,1.在栈中开辟空间(值类型);结构的new的1作用:调用结构的构造函数
            PersonStruct personStruct = new PersonStruct();
            //调用结构非静态方法:
            personStruct.M2();
            //调用结构静态方法:
            PersonStruct.M1();
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

        public char Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }

        private int _age;
        //结构中不可以写自动属性
        //public char Gender { get; set; }

        private char _gender;
        //在结构中可以写静态函数
        public static void M1()
        {
            Console.WriteLine("我是结构中的静态方法");
        }
        //在结构中可以写非静态函数
        public void M2()
        {
            Console.WriteLine("我是结构中的非静态方法");
        }
        //尝试在结构中声明构造函数
        //在结构中:构造函数里,只能给字段赋值,不可以给属性赋值;
        public PersonStruct(string name, int age,char gender)
        {
            //不可以给属性赋值:
            //this.Name = name;
            //this.Age = age;
            //this.Gender = gender;

            //给字段赋值
            this._age = age;
            this._name = name;
            this._gender = gender;
        }

        //尝试在结构中,构造函数重载_失败
        //public PersonStruct(string name)
        //{
        //    this._name = name;
        //}
    }
}
