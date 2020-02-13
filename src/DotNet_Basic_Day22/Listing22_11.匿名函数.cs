/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月13日 星期四 09:44:07
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.DotNet_Basic_Day22.Listing22_11
{
    ///<remarks=委托的签名要跟三个函数一致,有参数有返回值
    public delegate string DelProStr(string name);
    public class Listing22_11
    {
        ///<remarks=把方法作为参数传递到此公共方法,方法传递的类型:委托类型
        public static void ProStr(string[] names, DelProStr delProStr)
        {
            for (int i = 0; i < names.Length; i++)
            {
                //调用委托函数
                names[i] = delProStr(names[i]);
            }
        }
        ///<![CDATA[课题引入:
        ///三个需求使用了三个函数,三个函数只有调用的处理方法不一样---能不能合并调用一个函数解决?]]>
        public static void Main()
        {
            //三个需求
            //1、将一个字符串数组中每个元素都转换成大写
            //2、将一个字符串数组中每个元素都转换成小写
            //3、将一个字符串数组中每个元素两边都加上 双引号
            string[] names = { "abCDefG", "HIJKlmnOP", "QRsTuvW", "XyZ" };
            Console.WriteLine("-------转换成大写-------");
            //ProStrToUpper(names);
            //调用和公共方法:子方法可以直接赋值给委托函数;直接调用子方法名即可
            //ProStr(names, StrToUpper);
            #region 委托的推荐用法
            ProStr(names, delegate (string name)
            {
                return name.ToUpper();
            });
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            #endregion
            Console.WriteLine("-------转换成小写-------");
            //ProStrToLower(names);
            //转换小写
            //ProStr(names, StrToLower);
            ProStr(names, delegate (string name)
            {
                return name.ToLower();
            });
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("-------添加引号-------");
            //ProstrAddQuotes(names);
            //加双引号
            //ProStr(names, StrAddQuotes);
            ProStr(names, delegate (string name)
            {
                return "\"" + name + "\"";
            });
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }



        public static string StrToUpper(string name)
        {
            return name.ToUpper();
        }

        public static string StrToLower(string name)
        {
            return name.ToLower();
        }

        public static string StrAddQuotes(string name)
        {
            return "\"" + name + "\"";
        }
        //方案:将一个方法作为参数传递给另外一个方法,方法的类型为委托类型

        //注意:不能使用重载,因为参数一样

        //因为字符串属于引用类型,因此不需要返回值
        ///// <summary>
        ///// 转换成大写
        ///// </summary>
        ///// <param name="strs"></param>
        //public static void ProStrToUpper(string[] strs)
        //{
        //    for (int i = 0; i < strs.Length; i++)
        //    {
        //        strs[i] = strs[i].ToUpper();
        //        Console.WriteLine(strs[i]);
        //    }
        //}

        ///// <summary>
        ///// 转换成小写
        ///// </summary>
        ///// <param name="strs"></param>
        //public static void ProStrToLower(string[] strs)
        //{
        //    for (int i = 0; i < strs.Length; i++)
        //    {
        //        strs[i] = strs[i].ToLower();
        //        Console.WriteLine(strs[i]);
        //    }
        //}
        ///// <summary>
        ///// 加双引号
        ///// </summary>
        ///// <param name="strs"></param>
        //public static void ProstrAddQuotes(string[] strs)
        //{
        //    for (int i = 0; i < strs.Length; i++)
        //    {
        //        strs[i] = '\"' + strs[i] + '\"';
        //        Console.WriteLine(strs[i]);
        //    }
        //}
    }
}
