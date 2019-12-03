/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2019年12月3日 星期二 15:29:40
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.DotNet_Basic_Day22.Listing22_09
{
    public class Listing22_09
    {
        public static void Main()
        {
            //三个需求
            //1、将一个字符串数组中每个元素都转换成大写
            //2、将一个字符串数组中每个元素都转换成小写
            //3、将一个字符串数组中每个元素两边都加上 双引号
            string[] names = { "abCDefG", "HIJKlmnOP", "QRsTuvW", "XyZ" };
            Console.WriteLine("-------转换成大写-------");
            ProStrToUpper(names);
            Console.WriteLine("-------转换成小写-------");
            ProStrToLower(names);
            Console.WriteLine("-------添加引号-------");
            ProstrAddQuotes(names);
        }

        //因为字符串属于引用类型,因此不需要返回值
        /// <summary>
        /// 转换成大写
        /// </summary>
        /// <param name="strs"></param>
        public static void ProStrToUpper(string[] strs)
        {
            for (int i = 0; i < strs.Length; i++)
            {
                strs[i] = strs[i].ToUpper();
                Console.WriteLine(strs[i]);
            }
        }

        /// <summary>
        /// 转换成小写
        /// </summary>
        /// <param name="strs"></param>
        public static void ProStrToLower(string[] strs)
        {
            for (int i = 0; i < strs.Length; i++)
            {
                strs[i] = strs[i].ToLower();
                Console.WriteLine(strs[i]);
            }
        }

        public static void ProstrAddQuotes(string[] strs)
        {
            for (int i = 0; i < strs.Length; i++)
            {
                strs[i] = '\"' + strs[i] + '\"';
                Console.WriteLine(strs[i]);
            }
        }

    }
}
