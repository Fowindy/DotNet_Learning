using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_动物类的继承
{
    //Cat子类继承Animal父类
    public class Cat:Animal
    {
        //子类必须实现(重写)父类中的抽象方法,
        //除非子类也是抽象类
        public override void Eat()
        {
            Console.WriteLine("猫咪舔着吃...");
        }

        public override void Shout()
        {
            Console.WriteLine("猫咪喵喵叫...");
        }
    }
}
