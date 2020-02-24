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

            }
            return sb.ToString();
        }
    }
}
