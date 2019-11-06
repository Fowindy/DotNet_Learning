using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_06
{
    public class Father
    {
        private string _lastName;

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }
        private decimal _property;
        public decimal Property
        {
            get
            {
                return _property;
            }

            set
            {
                _property = value;
            }
        }
        private string _bloodType;
        public string BloodType
        {
            get
            {
                return _bloodType;
            }

            set
            {
                _bloodType = value;
            }
        }

        //父类加入构造函数,对各个属性进行初始化
        public Father(string lastName,decimal property,string bloodType)
        {
            this.LastName = lastName;
            this.Property = property;
            this.BloodType = bloodType;
        }

        //父类中加入打招呼的方法,因为不同儿女都有不同的打招呼;更合乎情理
        public void SayHello()
        {
            Console.WriteLine("我叫{0},我有{1}元钱,我是{2}型血",this.LastName,this.Property,this.BloodType);
        }
    }
    /// <summary>
    /// 子类继承了父类,需要调用父类的构造函数对子类的构造函数进行赋值初始化
    /// </summary>
    public class Son:Father
    {
        public Son(string lastName, decimal property, string bloodType) : base(lastName, property, bloodType)
        {
            //里面不需要写任何代码
        }
        public void PlayGame()
        {
            Console.WriteLine("儿子喜欢玩游戏.");
        }
    }
    public class Daughter : Father
    {
        public Daughter(string lastName, decimal property, string bloodType) : base(lastName, property, bloodType)
        {
        }
        public void Dance()
        {
            Console.WriteLine("女儿喜欢跳舞.");
        }
    }
    public class Program
    {
        public static void Main()
        {
            //作业：定义父亲类Father(姓lastName,财产property,血型bloodType),
            //儿子Son类(玩游戏PlayGame方法),女儿Daughter类(跳舞Dance方法)，
            //调用父类构造函数(:base())给子类字段赋值

            //实例化
            Son son = new Son("张三", 10m, "AB");
            //调用父类打招呼的方法,实际上是自己的打招呼;因为继承;
            son.SayHello();
            son.PlayGame();

            Daughter daughter = new Daughter("张梅梅", 100m, "O");
            daughter.SayHello();
            daughter.Dance();
        }
    }
}
