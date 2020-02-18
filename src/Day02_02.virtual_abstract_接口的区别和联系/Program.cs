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
    ///<![CDATA[07_接口的定义规范:
    ///         1.不要单接口再继承接口的做法,这样会导致接口污染;
    ///         2.接口尽可能功能单一,便于继承的单一管控,避免接口污染;]]>
    //06_声明多接口继承多接口实现
    public interface IJieKou : IFly, ISwim
    {
    }
    //01.声明一个会飞的接口
    //01_01_不建议单接口再继承接口的做法
    public interface IFly
    {
        void Fly();
    }
    //02.声明一个学生类继承会飞的接口
    //02_01_学生类再继承会游泳的接口
    //02_03_学生通过继承多接口来实现继承会飞和会游泳两种能力
    public class Student:IJieKou
    {
        public void Fly()
        {
            Console.WriteLine("我们会飞");
        }

        public void Swim()
        {
            Console.WriteLine("我们也会游泳");
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
    //08_声明一个Person类
    public class Person
    {
        //09_04_virtual虚方法的用法:如果父类子类有同名方法,则可以将父类方法定义成虚方法,子类重写即可
        public virtual void SayHello()
        {
            Console.WriteLine("阿尼海塞呦.莎娃迪卡,卡尼七娃..你好");
        }
    }
    //09_声明一个Teacher类并继承Person类
    public class Teacher:Person
    {
        //09_03_父类和子类中有同名方法,会各自调用各自方法;如果有意这样做,子类使用关键字new(关键字new的一种用法)
        //public new void SayHello()
        //{
        //    Console.WriteLine("恭喜发财,红包拿来");
        //}

        //09_05_重写父类SayHello虚方法_便实现了多态,需要重写的只有两种:虚方法和抽象方法
        public override void SayHello()
        {
            Console.WriteLine("恭喜发财,红包拿来");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //09_01_实例化Teacher对象调用SayHello方法_会隐藏父类SayHello方法
            Teacher teacher = new Teacher();
            teacher.SayHello();//恭喜发财,红包拿来
            //09_02_实例化Person对象调用SayHello方法_正常调用父类SayHello方法
            Person person = new Person();
            person.SayHello();//阿尼海塞呦.莎娃迪卡,卡尼七娃..你好
            Console.ReadKey();
        }
    }
}
