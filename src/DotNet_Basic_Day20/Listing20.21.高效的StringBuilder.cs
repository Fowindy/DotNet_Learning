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
            //插入元素
            sb.Insert(1, "ABC");//#1.在字符串序标1的文件插入"ABC"
            //替换元素
            sb.Replace('#', 'Z');//#2.将字符串中'#'替换成'Z'
            sb.Append(12.3);
            Console.WriteLine(sb.ToString());//张三#12.3//#1.张ABC三#12.3//#2.张ABC三Z12.3
        }
    }
}
