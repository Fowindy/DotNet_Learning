/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月23日 星期日 00:53:26
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.Day03_02.集合.Listing01_06
{
    public class Listing01_06
    {
        public static void Main()
        {
            string str = "Welcome to  ,China!China Welcomes you.";
            //01_采用Dictionary键值对来添加元素_字母作为Key_次数作为value
            Dictionary<char, int> dic = new Dictionary<char, int>();
            //02_首先将该字符串全部转换为小写
            str = str.ToLower();
            //03_循环遍历字符串中的字符
            for (int i = 0; i < str.Length; i++)
            {
                //04_判断该字符是否为字母
                if (char.IsLetter(str[i]))
                {
                    //05_如果字典中不存在该字母_则将该字母添加到字典中次数为1
                    if (!dic.ContainsKey(str[i]))
                    {
                        dic.Add(str[i], 1);
                    }
                    //06_如果字典中已经存在该字母_则该字母的值加1
                    else
                    {
                        dic[str[i]]++;
                    }
                }
            }
        }
    }
}
