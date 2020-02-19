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
            //01_09_比较两个字符串是否相等(忽略大小写)
            string str3 = "";
            str3.Equals(str2);//比较两个字符串是否相等
            //01_10_比较两个对象是否是同一个对象
            //object.ReferenceEquals();
            //05_01_实例化person1和person2两个对象并对Name赋同值
            Person person1 = new Person();
            person1.Name = "张三";
            Person person2 = new Person();
            person2.Name = "张三";
            //05_02_比较两个对象是否相等_False
            Console.WriteLine("person1和person2是否是同一个对象?{0}",person1.Equals(person2));
            //05_03_比较两个对象是否相等方法二_person1和person2不是同一个对象
            if (object.ReferenceEquals(person1,person2))
            {
                Console.WriteLine("person1和person2是同一个对象");
            }
            else
            {
                Console.WriteLine("person1和person2不是同一个对象");
            }
            Console.WriteLine("--------06_将对象变成字符变量--------");
            //06_03_变形1_将字符串分成两个字符串_是同一个对象
            //06_04_变形2_将字符串分成两个字符串变量_不是同一个对象
            string s3 = "张";
            string s4 = "三";
            string s1 = "张三";
            string s2 = s3 + s4;
            //06_01_比较两个字符串变量是否相等方法一_True
            Console.WriteLine(s1.Equals(s2));//True//这是不正确的,这个只是判断值是否相等
            //06_02_比较两个字符串变量是否相等方法二_True
            if (object.ReferenceEquals(s1,s2))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.WriteLine("--------07_IndexoOf的使用--------");
            string str4 = "哈哈,我又变帅了帅";//07_02_如果有多个则返回第一个的下标
            int n = str4.IndexOf('帅');//07_01_如果没有找到则返回-1
            Console.WriteLine(n);//6
            Console.WriteLine("--------08_Substring的使用--------");
            string str5 = "文能提笔控萝莉";
            //08_01_重载一_从下标位置截取后面所有字符
            str5 = str5.Substring(3);
            Console.WriteLine(str5);//笔控萝莉
            //08_02_重载二_从下标位置向后截取相应长度字符
            str5 = str5.Substring(1, 2);
            Console.WriteLine(str5);//控萝
            Console.WriteLine("--------09_Split的使用--------");
            //09_03_当有多个分隔符_加入多个即可
            string str6 = "yzk|ml|||sk|wc**w||zj**y||jk";
            //09_01_以分隔符分隔字符串
            //string[] str6s = str6.Split(new char[] { '|' });
            //09_02_Bug1_当出现连续分隔符时会出现空白分隔内容_使用RemoveEmptyEntries移除空格
            string[] str6s = str6.Split(new char[] { '|','*' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < str6s.Length; i++)
            {
                Console.WriteLine(str6s[i]);
            }
            Console.WriteLine("--------10_Join的使用--------");
            string[] str7 = { "卡卡西", "黑崎一护", "苍老师", "凤姐" };
            //10_01_Join在字符数组中间加入字符连接整个字符串
            string str8 = string.Join("★", str7);//卡卡西★黑崎一护★苍老师★凤姐
            Console.WriteLine(str8);
            Console.WriteLine("--------11_Replace的使用--------");
            string str9 = "小杨好猥琐";

            Console.ReadKey();
        }
    }
    //05_声明Person类并定义属性Name
    public class Person
    {
        public string Name { get; set; }
    }
}
