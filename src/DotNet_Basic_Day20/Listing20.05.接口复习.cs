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

    /// <summary>
    /// 不能在父类中声明Fly()的方法用于子类继承;因为不是所有的鸟都会飞
    /// </summary>
    public class Bird
    {
        public void Fly()
        {
            Console.WriteLine("大多数鸟类都会飞");
        }
    }
    /// <summary>
    /// 麻雀
    /// </summary>
    public class MaQue :Bird, IFlyable//多继承,父类在前接口在后
    {
        /// <summary>
        /// 这个函数是父类的?还是子类自己的?还是实现接口的?
        /// 从语法上:子类必须实现接口,如果没有实现,则语法通不过;现在语法通过,说明是接口的
        /// </summary>
        public void Fly()
        {
            Console.WriteLine("麻雀会飞");
        }
    }
    /// <summary>
    /// 企鹅
    /// </summary>
    public class QQ:Bird
    {

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
            IFlyable fly = new Plane();//new Bird();
            //表面上调用的是父类的Fly(),实际调用的是子类的Fly()
            fly.Fly();
        }
    }
}
