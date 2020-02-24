/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月24日 星期一 09:43:08
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.Day03_04.集合作业练习.Listing04_01
{
    public class Listing04_01
    {
        public static void Main()
        {
            //01_接收用户输入的日期
            Console.Write("请您输入日期(如二零一二年三月二日):");
            string strDate = Console.ReadLine();
            //02_调用方法转换成数字类型的日期
            string date = GetNumberByStrDate(strDate);
            //03_打印并输出数字日期结果
            Console.WriteLine(date);
        }

        private static string GetNumberByStrDate(string strDate)
        {
            //02_01_定义转换标准字符串
            string ziDian = "零0 一1 二2 三3 四4 五5 六6 七7 八8 九9";
            //02_02_先将用户输入的字符串转换成字符数组
            char[] chs = strDate.ToCharArray();
            //02_03_使用StringBuilder来存储字符串
            StringBuilder sb = new StringBuilder();
            //02_04_将转换标准字符串加载到字典集合中
            Dictionary<char, char> dic = new Dictionary<char, char>();
            string[] ziDians = ziDian.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < ziDians.Length; i++)
            {
                dic.Add(ziDians[i][0], ziDians[i][1]);
            }
            //02_05_对用户字符数组进行判断转换
            for (int i = 0; i < chs.Length; i++)
            {
                //02_05_01_判断字典中是否存在该字符_存在则直接追加
                if (dic.ContainsKey(chs[i]))
                {
                    sb.Append(dic[chs[i]]);
                }
                //02_05_02_判断当前字符是否是十_不是则直接追加_是则继续判断处理
                else if (chs[i] == '十')
                {
                    //02_05_03_如果前一个字符和后一个字符是年月或者月日_直接转换成10
                    //if ((chs[i - 1] == '年' && chs[i + 1] == '月') || (chs[i - 1] == '月' && chs[i + 1] == '日'))
                    //02_05_06_等价推荐方式_判断字典中是否存在前一个字符和后一个字符_前后均不存在则直接转换成10
                    if (!dic.ContainsKey(chs[i-1]) && !dic.ContainsKey(chs[i+1]))
                    {
                        sb.Append(10);
                    }
                    //02_05_04_如果前一个字符是年月后一个字符不是月日_直接转换成1
                    else if ((chs[i - 1] == '年' && chs[i + 1] != '月') || (chs[i - 1] == '月' && chs[i + 1] != '日'))
                    {
                        sb.Append(1);
                    }
                    //02_05_05_如果钱一个字符不是年月后一个字符是月日_直接转换成0
                    else if ((chs[i - 1] != '年' && chs[i + 1] == '月') || (chs[i - 1] != '月' && chs[i + 1] == '日'))
                    {
                        sb.Append(0);
                    }
                }
                else
                {
                    sb.Append(chs[i]);
                }
            }
            return sb.ToString();
        }
    }
}
