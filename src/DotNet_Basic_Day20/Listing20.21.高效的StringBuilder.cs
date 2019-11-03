using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_21
{
    public class Program
    {
        public static void Main()
        {
            //实例化
            StringBuilder sb = new StringBuilder();
            //追加元素
            sb.Append("张三");
            sb.Append('#');
            sb.Append(12.3);
            Console.WriteLine(sb.ToString());//张三#12.3
        }
    }
}
