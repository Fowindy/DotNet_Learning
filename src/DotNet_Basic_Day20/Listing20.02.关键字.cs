using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_02
{
    public partial class Person
    {
        private string _name;
    }

    public partial class Person
    {
        public void T()
        {
            //partial部分类本质上是同一个类,所有资源共享;
            _name = "可以访问";
        }
    }

    /// <summary>
    /// 密封类:不能被继承,但是可以继承其他类
    /// </summary>
    public sealed class Teacher :Person
    {
    }

    public class Program
    {
        public static void Main()
        {
            //partial 部分类
        }
    }
}
