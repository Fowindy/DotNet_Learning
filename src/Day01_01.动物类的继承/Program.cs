using System;

namespace Day01_01.动物类的继承
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Cat();//new Dog();
            a.Eat();
            a.Shout();
            Console.ReadKey();
        }
    }
}
