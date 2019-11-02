using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_09
{
    /// <summary>
    /// 动物类,吃和叫的方法;但是各种动物的吃喝均不一样;抽象类
    /// </summary>
    public abstract class Animal
    {
        /// <summary>
        /// 抽象方法不能有任何实现
        /// </summary>
        public abstract void Eat();
        public abstract void Bark();
    }

    public class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("猫舔着吃");
        }

        public override void Bark()
        {
            Console.WriteLine("猫喵喵叫");
        }
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("狗咬着吃");
        }

        public override void Bark()
        {
            Console.WriteLine("狗汪汪叫");
        }
    }
    public class Program
    {
        public static void Main()
        {
            //作业:动物Animal   都有吃Eat和叫Bark的方法，狗Dog和猫Cat叫的方法不一样.
            //父类中没有默认的实现所以考虑用抽象方法。

            //实例化
            Animal animal = new Dog();/*new Cat();*/
            animal.Eat();
            animal.Bark();
        }
    }
}
