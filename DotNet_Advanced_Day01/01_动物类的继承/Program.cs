using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_动物类的继承
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
