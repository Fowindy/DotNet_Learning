using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_16
{
    public class Program
    {
        public static void Main()
        {
            //课上练习3：接收用户输入的一句英文，将其中的单词以反序输出.“I Love You"→“I evoL uoY"
            string str = "I Love You";
            //首先拿到每一个单词
            string[] strNew = str.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            //遍历每一个单词
            for (int i = 0; i < strNew.Length; i++)
            {
                //将单词转换成字符数组
                char[] chs = strNew[i].ToCharArray();
                //对字符数组进行反转交换
                for (int j = 0; j < strNew[i].Length / 2; j++)
                {
                    char temp;
                    temp = chs[j];
                    chs[j] = chs[strNew[i].Length - 1 - j];
                    chs[strNew[i].Length - 1 - j] = temp;
                }
                //将交换后的字符数组转换成字符串存储到字符串数组中
                strNew[i] = new string(chs);
            }
            //将字符串数组加入空格连接成字符串
            string str1 = string.Join(' ', strNew);
            //输出结果
            Console.WriteLine(str1);//I evoL uoY
        }
    }
}
