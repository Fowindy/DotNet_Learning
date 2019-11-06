using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_12
{
    public interface IBarkable
    {
        void Bark(); 
    }

    public class Duck
    {
        public virtual void Swim()
        {
            Console.WriteLine("我是鸭子,我会游泳");
        }
    }

    public class RubberDuck : Duck, IBarkable
    {
        public override void Swim()
        {
            base.Swim();
        }
        public void Bark()
        {
            Console.WriteLine("橡皮鸭子唧唧叫");
        }
    }

    public class WoodDuck : Duck, IBarkable
    {
        public override void Swim()
        {
            base.Swim();
        }
        public void Bark()
        {
            Console.WriteLine("木头鸭子不会叫");
        }
    }

    public class RealDuck : Duck, IBarkable
    {
        public override void Swim()
        {
            base.Swim();
        }
        public void Bark()
        {
            Console.WriteLine("真实鸭子嘎嘎叫");
        }
    }
    public class Program
    {
        public static void Main()
        {
            //作业:橡皮rubber鸭子、木wood鸭子、真实的鸭子realduck。
            //三个鸭子都会游泳，而橡皮鸭子和真实的鸭子都会叫，
            //只是叫声不一样，橡皮鸭子“唧唧”叫，真实地鸭子“嘎嘎”叫，木鸭子不会叫.

            ///<![CDATA[思路如下:
            ///1.首先都属于鸭子父类;三个鸭子都会游泳,使用虚方法;
            ///2.三个鸭子都叫声不一样(叫声作为接口)]]>
            ///

            //实例化
            IBarkable barkable = new RubberDuck();/*new WoodDuck();*//*new RealDuck();*/
            Duck duck = new RubberDuck();/* new WoodDuck();*//*new RealDuck();*/
            barkable.Bark();
            duck.Swim();
        }
    }
}
