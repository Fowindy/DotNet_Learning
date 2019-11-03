using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_14
{
    public class Program
    {
        public static void Main()
        {
            //课上练习1：接收用户输入的字符串，将其中的字符以与输入相反的顺序输出。"abc"→"cba"
            string str = "abcdefg";
            //首先将字符串转换成字符数组
            char[] chs = str.ToCharArray();
            //使用Array.Reverse()方法翻转
            Array.Reverse(chs);
            //再将字符数组转换成字符串
            str = new string(chs);
            Console.WriteLine(str);//gfedcba
        }
    }
}
