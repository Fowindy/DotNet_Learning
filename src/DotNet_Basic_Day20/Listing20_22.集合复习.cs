/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2019年11月3日 星期日 23:26:26
 * ==============================================================================*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_22
{
    public class Listing20_22
    {
        public static void Main()
        {
            #region 1.ArrayList
            ArrayList arrayList = new ArrayList();
            arrayList.Add("王岳");
            arrayList.Add('A');
            arrayList.AddRange(new int[] { 123, 456, 789 });
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
