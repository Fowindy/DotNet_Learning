using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_11
{
    public interface IFlyable
    {
        void Fly();
    }

    public class Bird
    {
        public Bird(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void SayHello()
        {
            Console.WriteLine("我是{0}",Name);
        }
    }
    public class Sparrow:Bird,IFlyable
    {
        public Sparrow(string name) : base(name)
        {
        }

        public void Fly()
        {
            Console.WriteLine("{0}能飞",Name);
        }
    }

    public class Ostrich :Bird, IFlyable
    {
        public Ostrich(string name) : base(name)
        {
        }

        public void Fly()
        {
            Console.WriteLine("{0}不能飞",Name);
        }
    }

    public class Penguin:Bird,IFlyable
    {
        public Penguin(string name) : base(name)
        {
        }

        public void Fly()
        {
            Console.WriteLine("{0}不能飞",Name);
        }
    }



    public class Listing20_11
    {
        private static void ABC()
        {
            Console.WriteLine();
        }
        public static void Main()
        {
            //作业:鸟-麻雀sparrow['spærəu] ，鸵鸟ostrich['ɔstritʃ] ，
            //企鹅penguin['pengwin] ，鹦鹉parrot['pærət]
            //鸟能飞,鸵鸟，企鹅不能。。。你怎么办
            ///<![CDATA[思路如下:
            ///1.都属于鸟类,但是有的能飞有的不能飞
            ///2.使用接口]]>
            ///

            //实例化
            IFlyable flyable = new Parrot("鹦鹉");/*new Sparrow("麻雀");*//*new Penguin();*//*new Ostrich();*/
            Bird bird = new Parrot("鹦鹉");/*new Sparrow("麻雀");*/
            bird.SayHello();
            flyable.Fly();
            ABC();
        }
    }

    public class Parrot : Bird, IFlyable
    {
        public Parrot(string name) : base(name)
        {
        }

        public void Fly()
        {
            Console.WriteLine("{0}能飞", Name);
        }
    }


}
