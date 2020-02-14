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
