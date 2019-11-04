/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2019年11月4日 星期一 09:00:20
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_23
{
    public class Listing20_23
    {
        public static void Main()
        {
            #region 集合案例1:分拣奇偶数
            //案例：把分拣奇偶数的程序用泛型实现。int[] nums={1,2,3,4,5,6,7,8,9};奇数在左边 偶数在右边 
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //声明奇偶数组List集合(因为不知道长度,所以不建议用数组)
            List<int> listJi = new List<int>();
            List<int> listOu = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    listOu.Add(nums[i]);
                }
                else
                {
                    listJi.Add(nums[i]);
                }
            }
            //因为奇数放在左边,因此在listJi后添加listOu的集合即可
            listJi.AddRange(listOu);
            //遍历输出集合
            foreach (var item in listJi)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
