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
            Console.WriteLine("----------------------------");
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

            #region 3.集合:List
            Console.WriteLine("----------------------------");
            List<int> list = new List<int>();
            //添加元素
            list.Add(123);//123
            //添加多个元素
            list.AddRange(new int[] { 456,789,234});//123,456,789,234
            //在集合序标1的位置插入999
            list.Insert(1,999);//123,999,456,789,234
            //在集合序标3的位置插入数组
            list.InsertRange(3, new int[] { 777, 666, 555 });
            //123,999,456,777, 666, 555,789,234
            //移除集合中指定单个元素
            list.Remove(777);//123,999,456,666, 555,789,234
            //移除集合序标为5的元素
            list.RemoveAt(5);//123,999,456,666, 555,234
            //移除集合序标2开始的两个元素
            list.RemoveRange(2, 2);//123,999,555,234
            //判断集合是否包含某个元素
            if (list.Contains(555))
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            #endregion
        }
    }
}
