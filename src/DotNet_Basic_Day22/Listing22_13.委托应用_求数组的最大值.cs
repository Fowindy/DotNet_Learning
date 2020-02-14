/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月14日 星期五 10:05:48
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.DotNet_Basic_Day22.Listing22_13
{
    /// <summary>
    /// 创建委托类型
    /// </summary>
    /// <param name="object1">比较的第一项</param>
    /// <param name="object2">比较的第二项</param>
    /// <returns></returns>
    public delegate int DelCompara(object object1, object object2);
    public class Listing22_13
    {
        public static void Main()
        {
            ///<![CDATA[调用委托实现功能方法1]]>
            object[] obj1 = { 1, 2, 3, 4, 5 };
            ///<![CDATA[此处调用委托的具体方法:分整型int和字符串两种类型
            ///         因此需要构建委托的具体方法]]>
            //object result1 = GetMax(obj1, Compare1);
            ///<![CDATA[匿名委托函数实现1_不需要具体函数]]>
            object result1 = GetMax(obj1, delegate (object o1, object o2)
             {
                 return (int)o1 - (int)o2;
             });
            Console.WriteLine(result1);

            ///<![CDATA[调用委托实现功能方法2]]>
            object[] obj2 = { "A", "AB", "ABC", "ABCDEF", "ABCD", "ABCDE" };
            ///<![CDATA[此处调用委托的具体方法:字符串类型]]>
            //object result2 = GetMax(obj2, Compare2);
            object result2 = GetMax(obj2, delegate (object o1, object o2)
             {
                 return ((string)o1).Length - ((string)o2).Length;
             });
            Console.WriteLine(result2);
        }

        ///<remarks=1.因为下面两个函数的参数类型不一致(int[]和string[]),所有两者构成重载
        ///<!--问题:能否将这两个函数合二为一?-->
        ///<![CDATA[分析:返回值类型和参数类型均可用object表示,
        ///         唯一不同的地方是:if语句,if语句采用委托即可实现
        ///         综上分析:两个函数可以合而为一]]>

        /// <summary>
        /// 获取整型数组中的最大值
        /// </summary>
        /// <param name="nums">整型数组</param>
        /// <returns></returns>
        ///<![CDATA[传入委托方法参数]]>
        public static Object GetMax(Object[] nums,DelCompara delCompara)
        {
            Object max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                ///<![CDATA[分析:if语句中需要传一个比较的方法委托,来区分是何种比较
                ///         if里面为bool类型,将比较转换成max-num[i] < 0
                ///         则max-num[i]为整型,也就是委托的返回值为整型]]>
                ///<![CDATA[调用委托方法]]>
                if (delCompara(max,nums[i]) < 0)
                {
                    max = nums[i];
                }
            }
            return max;
        }

        ///<![CDATA[构建委托具体类型方法1_整型
        ///         委托具体方法需要和委托有相同的签名]]>
        public static int Compare1(object obj1, object obj2)
        {
            //将object强转为int类型
            int n1 = (int)obj1;
            int n2 = (int)obj2;
            //返回两项的差值
            return n1 - n2;
        }

        ///<![CDATA[构建委托具体类型方法2_字符串类型
        ///         委托具体方法需要和委托有相同的签名]]>
        public static int Compare2(object obj1, object obj2)
        {
            //将object强转为string类型
            string str1 = (string)obj1;
            string str2 = (string)obj2;
            //返回两项字符串长度的差值
            return str1.Length - str2.Length;
        }
        /// <summary>
        /// 获取字符数组长度最长的字符
        /// </summary>
        /// <param name="names">字符数组</param>
        /// <returns></returns>
        //public static string GetMax(string[] names)
        //{
        //    string max = names[0];
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        if (max.Length < names[i].Length)
        //        {
        //            max = names[i];
        //        }
        //    }
        //    return max;
        //}
    }
}
