using System;
using System.Collections.Generic;
using System.Text;

namespace Day01_01.动物类的继承
{
    //创建动物类父类
    public abstract class Animal
    {
        //类默认的访问修饰符是??? ---internal
        //因为各种动物吃和叫的方法不一样,因此在父类中抽象此方法

        //抽象方法:
        //1.抽象方法在父类中不能有实现;
        //2.抽象方法用abstract标识;
        //3.抽象方法必须在抽象类中;
        public abstract void Eat();

        public abstract void Shout();

    }
}
