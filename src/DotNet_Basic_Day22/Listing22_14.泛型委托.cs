﻿/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月14日 星期五 15:34:24
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.DotNet_Basic_Day22.Listing22_14
{
    public delegate int DelCompare<T>(T obj1, T obj2);
    public class Listing22_14
    {
        ///<![CDATA[问题的提出1:如13节涉及到强制转换object,就是容易出现拆装箱
        ///         解决的方案1:采用泛型委托来解决拆装箱的问题]]>
        public static void Main()
        {
            ///<![CDATA[泛型委托的实现_int类型_Lamda表达式]]>
            int[] nums = { 1, 2, 3, 4, 5 };
            int result1 = GetMax<int>(nums, (int n1,int n2) =>
             {
                 return n1 - n2;
             });
            Console.WriteLine(result1);

            ///<![CDATA[泛型委托的实现_string类型_Lamada表达式]]>
            string[] names = { "A", "AB", "ABC", "ABCDEF", "ABCD", "ABCDE" };
            string result2 = GetMax<string>(names, (string str1,string str2) =>
             {
                 return str1.Length - str2.Length;
             });
            Console.WriteLine(result2);
        }

        public static T GetMax<T>(T[] nums,DelCompare<T> delCompare)
        {
            T max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (delCompare(max,nums[i]) < 0)
                {
                    max = nums[i];
                }
            }
            return max;
        }
    }
}
