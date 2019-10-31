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

    public class Program
    {
        public static void Main()
        {
            //partial 部分类
        }
    }
}
