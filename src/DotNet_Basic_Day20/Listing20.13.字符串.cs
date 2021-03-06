﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_13
{
    public class Program
    {
        public static void Main()
        {
            //1.字符串的不可变性;
            //string s1 = "张三";
            //s1 = "李四";//表面上是赋值,实际上在内存中又开辟了一段内存空间;"张三"还在,只是没有变量指向它,成了垃圾数据;最终会被垃圾回收机制GC回收;
            //GC:垃圾回收机制,当程序结束之后,GC会扫描整个内存空间,发现垃圾数据则回收;
            //有些资源GC是不能帮助回收的,比如FileStream(文件流),我们写在Using中
            //2.IsNullOrEmpty()函数
            //if (string.IsNullOrEmpty(s1))//当s1==""或者s1==null时,为空
            //{
            //    Console.WriteLine("为空");
            //}
            //else
            //{
            //    Console.WriteLine("不为空");
            //}

            //3.ToCharArray()函数;
            //字符串可以看作是Char类型的只读数组
            string s = "abcdefg";
            //我们可以通过下标访问字符串中的某一个字符
            Console.WriteLine(s[3]);//d
            //但是我们不能改变某一个字符,如下操作不允许:
            //s[3] = 'H';//因为是只读的

            //如果要改变字符串中的某一个字符,通过下面方法实现:
            //首先将字符串通过ToCharArray()方法转换成字符数组
            char[] chs = s.ToCharArray();
            chs[3] = 'H';
            //然后再将改变后的char数组转换成字符串,达到更改字符串的目的
            //s = chs.ToString();//注意:不能通过这种方式实现
            //需要重新实例化一个字符串
            s = new string(chs);//abcHefg
            Console.WriteLine(s);

            //4.Equals()函数;比较两个字符串是否相同,忽略大小写
            string s1 = "c#";
            string s2 = "C#";
            if (s1.Equals(s2,StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("相同");
            }
            else
            {
                Console.WriteLine("不相同");
            }

            //5.Substring();截取字符串,两个重载,举例如下:
            string s3 = "abcdefg";
            string s3New = s3.Substring(3);//从包含序标3截取到最后
            Console.WriteLine(s3New);//defg
            string s3New1 = s3.Substring(3, 3);//从包含序标3截取3个字符
            Console.WriteLine(s3New1);//def

            //6.Split();分隔字符串
            string str = "abcd , , fd, fdafd   [[  ---";//去除除字母之外的字符
            //将不需要的字符放在字符数组中转换成空格,然后删除所有空格
            string[] strNew = str.Split(new char[] { ',', ' ', '[', '-' }, StringSplitOptions.RemoveEmptyEntries);
            str = string.Join("", strNew);//将字符串数组用""分隔连接起来返回字符串
            Console.WriteLine(str);//abcdfdfdafd
            //7.Join();字符串数组连接符
            string[] str1 = { "张三", "王五", "李四", "赵六" };
            string str2 = string.Join("|", 'c', true, 3.13, 100, 1000m, "张三");
            //用"|"隔开,返回字符串
            str = string.Join("|", str1);
            Console.WriteLine(str);//张三|王五|李四|赵六
            Console.WriteLine(str2);//c|True|3.13|100|1000|张三
            //8.Replace();将字符串中的指定字符替换成目标字符;
            str2 = str2.Replace("张三", "**");
            Console.WriteLine(str2);//c|True|3.13|100|1000|**
            //9.Trim(),去除两端的空格;TrimStart()去除首空格;TrimEnd()去除尾空格
            string str3 = " 分公司答复 惹我日本恢复 就好地方 ";
            str3 = str3.Trim();//去除两端的空格
            Console.WriteLine(str3);//分公司答复 惹我日本恢复 就好地方
        }
    }
}
