using System;
using System.Collections.Generic;
using System.Text;

namespace Day01_01.动物类的继承
{
    //Dog子类继承Animal父类
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("狗狗咬着吃...");
        }

        public override void Shout()
        {
            Console.WriteLine("狗狗汪汪叫...");
        }
    }
}
