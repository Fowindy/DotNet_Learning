using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_04
{
    //抽象类注意1:抽象成员必须在抽象类中;
    //抽象类注意2:抽象方法不能有任何实现;
    //抽象类注意3:子类重写父类的抽象方法,必须和父类抽象方法有相同的签名;(传参和返回值的类型个数一致)
    //但如果父类是抽象类
    public abstract class Person
    {
        //父类中如果有方法需要让子类重写,则可以将该方法标记为virtual
        //虚方法在父类中必须有实现,哪怕是空实现;(有方法体无内容)
        public virtual void SayHello()
        {
        }

        public abstract void Test();

        public abstract double Test1(string name);
    }

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
