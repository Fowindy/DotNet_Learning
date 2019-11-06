using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_07
{
    /// <summary>
    /// 汽车父类
    /// </summary>
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Color { get; set; }

        public void Run()
        {
            Console.WriteLine("我是汽车,我会跑");
        }

        //构造函数,给父类属性赋值初始化
        public Vehicle(string brand, string color)
        {
            this.Brand = brand;
            this.Color = color;
        }
    }

    /// <summary>
    /// 卡车子类继承汽车父类
    /// </summary>
    public class Truck : Vehicle
    {
        //卡车自己的属性
        public double Weight { get; set; }
        //调用父类的构造函数对子类的构造函数进行赋值初始化
        public Truck(string brand, string color,double weight) : base(brand, color)
        {
            //对子类自己的属性进行赋值初始化
            this.Weight = weight;
        }

        public void LaHuo()
        {
            Console.WriteLine("我是{1}的{2}卡车,我可以拉{0}吨货",this.Weight,this.Color,this.Brand);
        }
    }

    public class Car : Vehicle
    {
        //轿车自己的属性
        public int Passenger { get; set; }
        public Car(string brand, string color,int passenger) : base(brand, color)
        {
            //对子类自己的属性进行赋值初始化
            this.Passenger = passenger;
        }

        public void ZaiKe()
        {
            Console.WriteLine("我是{1}的{2}轿车,我可以载{0}个人", this.Passenger, this.Color, this.Brand);
        }
    }
    public class Program
    {
        public static void Main()
        {
            //作业：定义汽车类Vehicle属性（brand(品牌),color（颜色））方法run，
            //子类卡车(Truck) 属性weight载重  方法拉货，轿车 (Car) 属性passenger载客数量  方法载客

            //实例化
            Truck truck = new Truck("东风", "红色", 20);
            truck.LaHuo();

            Car car = new Car("丰田", "黑色", 5);
            car.ZaiKe();
        }
    }
}
