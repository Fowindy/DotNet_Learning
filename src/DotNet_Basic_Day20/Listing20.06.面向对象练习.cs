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
    }

    public class Son:Father
    {
        public void PlayGame()
        {
            Console.WriteLine("儿子喜欢玩游戏.");
        }
    }

    public class Daughter : Father
    {
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
        }
    }
}
