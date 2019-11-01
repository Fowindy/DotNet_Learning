﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_04
{
    //但如果父类是抽象类
    public abstract class Person
    {
        //父类中如果有方法需要让子类重写,则可以将该方法标记为virtual
        //虚方法在父类中必须有实现,哪怕是空实现;(有方法体无内容)
        public virtual void SayHello()
        {
        }

        public abstract void Test();
    }

    public class Student : Person
    {
        //则子类必须重写父类中的抽象成员
        public override void Test()
        {
            
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
