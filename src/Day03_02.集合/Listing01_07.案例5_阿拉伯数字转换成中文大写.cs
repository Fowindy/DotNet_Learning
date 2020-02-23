/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月23日 星期日 08:47:10
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.Day03_02.集合.Listing01_07
{
    public class Listing01_07
    {
        public static void Main()
        {
            string str = "1壹 2贰 3叁 4肆 5伍 6陆 7柒 8捌 9玖 0零";
            Console.Write("请输入需要转换的阿拉伯数字:");
            string input = Console.ReadLine();
            //01_使用键值对将转换规则添加到字典
            Dictionary<int, char> dic = new Dictionary<int, char>();
            //02_对转换规则字符串进行分割成字符串数组处理
            string[] strNew = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //03_将字符串数组添加到字典中
            for (int i = 0; i < strNew.Length; i++)
            {
                dic.Add(strNew[i][0], strNew[i][1]);
            }

        }
    }
}
