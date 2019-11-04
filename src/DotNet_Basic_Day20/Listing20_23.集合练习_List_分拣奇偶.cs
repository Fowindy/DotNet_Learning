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

            #region 集合案例2.从集合中取出集合转换成数组
            Console.WriteLine("---------------------------");
            List<int> listJi1 = new List<int>();
            //遍历添加奇数
            foreach (var item in nums)
            {
                if (item % 2 != 0)
                {
                    listJi1.Add(item);
                }
            }
            //集合转换成数组
            int[] numsJi = listJi1.ToArray();
            foreach (var item in numsJi)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region 集合案例3.从List集合中获取最大值
            Console.WriteLine("---------------------------");
            //集合初始化器
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //假设最大值为第一个
            int max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                max = list[i] >= max ? list[i] : max;
            }
            Console.WriteLine("最大值为:{0}",max);
            #endregion

            #region 集合案例3_1.对象初始化器

            #region 对象初始化方法3:对象初始化
            Person person = new Person() { Name = "张三", Age = 19, Gender = '男' }; 
            #endregion
#if false
            #region 对象初始化方法2:实例化对象后赋值
            Person person = new Person();
            person.Name = "张三";
            person.Age = 18;
            person.Gender = '男';
            #endregion
#endif
            #endregion
        }
    }
    //对象初始化有三种方式:
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
#if false
        #region 对象初始化方法1:构造函数法
        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        #endregion  
#endif
    }
}
