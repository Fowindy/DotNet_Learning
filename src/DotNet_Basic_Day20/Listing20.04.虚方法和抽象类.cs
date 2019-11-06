using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_04
{
    //抽象类注意1:抽象成员必须在抽象类中;
    //抽象类注意2:抽象方法不能有任何实现;
    //抽象类注意3:子类重写父类的抽象方法,必须和父类抽象方法有相同的签名;(传参和返回值的类型个数一致)
    //抽象类注意4：抽象类中不都是抽象成员;字段,属性,函数,虚方法都可以;
    //抽象类注意5.由于抽象成员没有任何实现,所以子类必须将抽象成员重写;
    //抽象类注意6.抽象类不可以实例化;静态类也不能实例化,接口也不能实例化;
    //抽象类的作用:抽象类的作用就是为了让子类继承;重写抽象方法;
    //抽象类注意7.抽象方法不能用static修饰;调用抽象方法时必须用子类去调,如果static可以修饰则类名也可以调用;
    //但如果父类是抽象类,则子类必须重写父类中的抽象成员
    public abstract class Person
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
        //有参的构造函数
        public Person(string name)
        {
            this.Name = name;
        }

        public Person()
        {
        }

        //父类中如果有方法需要让子类重写,则可以将该方法标记为virtual
        //虚方法在父类中必须有实现,哪怕是空实现;(有方法体无内容)
        public virtual void SayHello()
        {
        }

        public abstract void Test();

        public abstract double Test1(string name);

        //public abstract static double Test(string name);
    }

    /// <summary>
    /// 子类会调用父类默认的无参的构造函数
    /// </summary>
    public class Student : Person
    {
        //则子类必须重写父类中的抽象成员
        public override void Test()
        {
            
        }

        public override double Test1(string name)//括号中的签名和父类抽象方法保存一致
        {
            return 123;
        }
        //子类可以重写父类中的虚方法,也可以不重写父类中的虚方法
    }
    public class Program
    {
        public static void Main()
        {
        }
    }
}
