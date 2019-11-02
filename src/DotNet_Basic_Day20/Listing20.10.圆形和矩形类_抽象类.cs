using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_10
{
    /// <summary>
    /// 形状父类
    /// </summary>
    public abstract class Shape
    {
        public abstract void Area();
        public abstract void Perimeter();
    }

    public class Circle : Shape
    {
        public double R { get; set; }
        /// <summary>
        /// 创建构造函数对属性进行初始化
        /// </summary>
        /// <param name="r"></param>
        public Circle(double r)
        {
            this.R = r;
        }
        public override void Area()
        {
            Console.WriteLine("圆形_半径为:{0},面积是:{1}",this.R,Math.PI*R*R);
        }

        public override void Perimeter()
        {
            Console.WriteLine("圆形_半径为:{0},周长是:{1}",this.R,2*Math.PI*R);
        }
    }

    public class Square:Shape
    {
        public Square(double width, double length)
        {
            this.Width = width;
            this.Length = length;
        }

        public double Length { get; set; }
        public double Width { get; set; }

        public override void Area()
        {
            Console.WriteLine("矩形_长为:{0},宽为:{1},面积为:{2}", Length, Width,Length*Width);
        }
        public override void Perimeter()
        {
            Console.WriteLine("矩形_长为:{0},宽为:{1},周长为:{2}", Length, Width,2*(Length+Width));
        }
    }

    public class Rectangle:Shape
    {
        public Rectangle(double side)
        {
            Side = side;
        }

        public double Side { get; set; }
        public override void Area()
        {
            Console.WriteLine("正方形_边长为:{0},面积为:{1}", Side, Side * Side);
        }

        public override void Perimeter()
        {
            Console.WriteLine("正方形_边长为:{0},周长为:{1}", Side, Side * 4);
        }
    }
    public class Program
    {
        public static void Main()
        {
            //作业:计算形状Shape(圆形Circle,矩形Square,正方形Rectangle)的面积,周长

            ///<![CDATA[思路如下:
            ///1.圆形,矩形,正方形都属于形状,所以创建形状父类
            ///2.每个形状计算面积和周长的方法不一样,所以使用抽象类]]>
            ///

            //实例化
            Shape shape = new Rectangle(8);/*new Square(13.4,24.5);*//*new Circle(23.65);*/
            shape.Area();
            shape.Perimeter();
        }
    }
}
