/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月18日 星期二 19:25:49
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day02_06.字符串的特性
{
    public class Program
    {
        static void Main(string[] args)
        {
            //01_字符串的不可变性
            string str = "床前明月光";
            //01_01_想改变字符串中的某一个字符_不可行_因为字符串是只读的
            //str[2] = "阴";
            Console.WriteLine(str[2]);//明//字符串是只读的
            //01_02_这是重新赋值不是改变字符串
            str = "低头思故乡";
            //01_03_大量字符串拼接案例_次方增长爆内存
            //for (int i = 0; i < 27; i++)
            //{
            //    str += str;//----大量字符串拼接
            //}
            //01_04_当需要大量字符串拼接时,采用StringBuilder
            StringBuilder stringBuilder = new StringBuilder();
            //for (int i = 0; i < 64; i++)
            //{
            //    stringBuilder.Append(str).ToString();
            //    if (i == 63)
            //    {
            //        Console.WriteLine(stringBuilder.Append(str).ToString());
            //    }
            //}
            //01_05_string.IsNullOrEmpty方法的用法
            //01.06.null和""的区别:null在内存没有开空间,""在内存中开空间了;垃圾回收器:null可以被回收
            string str1 = null;
            if (string.IsNullOrEmpty(str1))
            {

            }
            //01.07.修改字符串操作
            string str2 = "今天天气格外好,小赵来到桃花岛,看见了老马在洗澡......";
            ///<![CDATA[01_08_思路_字符串转成字符数组,然后进行修改再转化成字符串]]>
            char[] chs = str2.ToCharArray();
            chs[6] = '坏';
            str2 = new string(chs);
            Console.WriteLine(str2);
            Console.ReadKey();
        }
    }
}
