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
    public class Listing22_13
    {
        public static void Main()
        {
        }

        ///<remarks=1.因为下面两个函数的参数类型不一致(int[]和string[]),所有两者构成重载
        ///<!--问题:能否将这两个函数合二为一?-->

        /// <summary>
        /// 获取整型数组中的最大值
        /// </summary>
        /// <param name="nums">整型数组</param>
        /// <returns></returns>
        public static int GetMax(int[] nums)
        {
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (max < nums[i])
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
        public static string GetMax(string[] names)
        {
            string max = names[0];
            for (int i = 0; i < names.Length; i++)
            {
                if (max.Length < names[i].Length)
                {
                    max = names[i];
                }
            }
            return max;
        }
    }
}
