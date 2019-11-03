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

            #region 2.Hashtable
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "AAA");
            hashtable.Add(2, "BBB");
            hashtable.Add(3, "CCC");

            string s = (string)hashtable[1];
            if (hashtable.Contains(1)) //判断哈希表是否包含特定键,其返回值为true或false
                Console.WriteLine("the 1 key exist");
            hashtable.Remove(3);//移除一个keyvalue键值对
            Console.WriteLine(hashtable[1]);//此处输出AAA
            hashtable.Clear();//移除所有元素
            Console.WriteLine(hashtable[1]); //此处将不会有任何输出
            #endregion
        }
    }
}
