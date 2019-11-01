using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_05
{
    public interface IFlyable
    {
        //接口里面的成员不允许有访问修饰符(默认为public),方法不允许有实现;
        void Fly();
    }

    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鸟会飞");
        }
    }

    public class Plane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("飞机会飞");
        }
    }
    public class Program
    {
        public static void Main()
        {
            //接口是什么?什么时候使用接口?使用接口的目的是什么?多态
            //鸟会飞,飞机也会飞(因为鸟和飞机没有父类)
            //接口的实现:接口指向子类对象
            IFlyable fly = new Bird();
            //表面上调用的是父类的Fly(),实际调用的是子类的Fly()
            fly.Fly();
        }
    }
}
