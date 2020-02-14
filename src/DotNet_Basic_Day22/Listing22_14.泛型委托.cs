/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月14日 星期五 15:34:24
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.DotNet_Basic_Day22.Listing22_14
{
    public delegate int DelCompare(object obj1, object obj2);
    public class Listing22_14
    {
        ///<![CDATA[问题的提出1:如13节涉及到强制转换object,就是容易出现拆装箱
        ///         解决的方案1:采用泛型委托来解决拆装箱的问题]]>
        public static void Main()
        {
        }

        public static object GetMax(object[] nums,DelCompare delCompare)
        {
            object max = nums[0];
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
