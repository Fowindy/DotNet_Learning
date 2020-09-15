/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月25日 星期二 05:40:53
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day03_05.装箱和拆箱
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            //01_装箱_值类型隐式转换成引用类型_饼干放盒子里
            object obj = num;

            //02_拆箱_引用类型强制转换为值类型_饼干拿出盒子
            int n = (int)obj;
            //02_01_拆箱失败_int型的引用类型强转成double类型_饼干盒子里拿不出面包
            double d = (double)obj;

            //03_装箱和拆箱效率低_因为中间进行了object转换
            int num1 = 3;
            object obj1 = num1;
            Console.WriteLine(num1);

            //04_问题_装箱3次拆箱1次
            int num2 = 10;
            object obj2 = num2;//第一次装箱
            num2 = 100;
            //num2转换成object:第二次装箱;(int)obj2:第一次拆箱;(int)obj2转换成object:第三次装箱
            Console.WriteLine(num2 + "," + (int)obj2);

            //05_问题_装箱1次拆箱0次
            int num3 = 10;
            //05_01_ToString并没有发生装箱_因为ToString不是Object类下的方法
            string s1 = num3.ToString();
            //05_02_GetType发生了装箱_因为GetType是Object类下的方法
            string s2 = num3.GetType().ToString();
            Console.WriteLine(s1 + "\t\t\t" + s2);

            //06_问题_装箱3次拆箱0次
            string s3 = "a";
            int num4 = 10;
            double d1 = 99.9;
            //06_01_第一次装箱_int类型隐式转换成object类型
            object obj3 = 10;
            string s4 = "x";
            string s5 = s3 + num4 + d1 + obj3 + s4;
            //06_02_WriteLine方法参数隐式调用object类型_所以num4进行第二次装箱_d1进行第三次装箱
            Console.WriteLine(s5);
            
            //07_学装箱拆箱的目的是为了尽可能避免装箱拆箱_提高效率
        }
    }
}
