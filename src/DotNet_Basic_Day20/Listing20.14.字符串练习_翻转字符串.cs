﻿using System;
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
#if false
            #region 方法1_调用Array.Reverse()方法翻转实现
            //使用Array.Reverse()方法翻转
            Array.Reverse(chs);

            #endregion
#elif true
            #region 方法二_使用for循环交换实现
            for (int i = 0; i < chs.Length/2; i++)
            {
                //进行头尾字符交换
                char temp;
                temp = chs[i];
                chs[i] = chs[chs.Length-1-i];
                chs[chs.Length - 1 - i] = temp;
            }
            #endregion
#endif
            //再将字符数组转换成字符串
            str = new string(chs);
            Console.WriteLine(str);//gfedcba
        }
    }
}
