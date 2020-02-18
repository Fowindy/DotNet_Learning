﻿/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月18日 星期二 10:27:42
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day02_02.virtual_abstract_接口的区别和联系
{
    //01.声明一个会飞的接口
    public interface IFly
    {
        void Fly();
    }
    //02.声明一个学生类继承会飞的接口
    public class Student:IFly
    {
        public void Fly()
        {
            Console.WriteLine("我们会飞");
        }
    }
    //03.声明一个Animal抽象类和叫的抽象方法
    public abstract class Animal
    {
        public abstract void Shout();
    }
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
