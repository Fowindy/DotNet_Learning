/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月19日 星期三 15:44:31
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.Day02_07.字符串练习.Listing07_01
{
    public class Listing07_01
    {
        public static void Main()
        {
            #region 07_01_01_第一种方式:直接反向输出不能重复调用
            string str1 = "就这样被你征服,帮你洗衣服.";
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                Console.Write(str1[i]);//.服衣洗你帮,服征你被样这就
            }
            #endregion
        }
    }
}
