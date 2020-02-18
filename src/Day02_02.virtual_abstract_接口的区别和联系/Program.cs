/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月18日 星期二 10:27:42
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day02_02.virtual_abstract_接口的区别和联系
{
    //01.声明一个会飞的接口
    public interface IFly
    {
        void Fly();
    }
    //02.声明一个学生类继承会飞的接口
    public class Student:IFly
    {
        public void Fly()
        {
            Console.WriteLine("我们会飞");
        }
    }
    //03.声明一个Animal抽象类和叫的抽象方法
    public abstract class Animal
    {
        public abstract void Shout();
    }
    //04.声明一个Dog类继承Animal
    //04_01_Dog类继承IFly接口实现飞的功能
    ///<![CDATA[04_02_接口和抽象方法的应用区别:
    ///         1.不同子类之间可以抽出来一个父类,则将该父类声明成抽象类;
    ///         2.狗和学生不同种类不能抽象出一个父类,但是他们都能完成会飞的功能,则将此功能声明成接口;]]>
    public class Dog:Animal,IFly
    {
        //重写
        public override void Shout()
        {
            Console.WriteLine("汪汪叫...");
        }

        public void Fly()
        {
            Console.WriteLine("我是哮天犬,我会飞");
        }
    }
    //05_声明一个会游泳的接口
    public interface ISwim
    {
        void Swim();
    }
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
