using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_05
{
    public interface IFlyable
    {
        //接口里面的成员不允许有访问修饰符(默认为public),方法不允许有实现;
        void Fly();
    }
    public class Program
    {
        public static void Main()
        {
            //接口是什么?什么时候使用接口?使用接口的目的是什么?
            //鸟会飞,飞机也会飞(因为鸟和飞机没有父类)
        }
    }
}
