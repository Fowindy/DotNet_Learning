/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月20日 星期四 12:52:27
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.Day02_10.字符串练习2.Listing01_02
{
    public class Listing01_02
    {
        public static void Main()
        {
            //练习2_请将字符串数组{ "中国", "美国", "巴西", "澳大利亚", "加拿大" }中的内容反转。然后输出反转后的数组
            //01_01_01_方法一_遍历转换
            string[] states = { "中国", "美国", "巴西", "澳大利亚", "加拿大" };
            string temp = null;
            //01_01_01_01_遍历反转字符数组
            for (int i = 0; i < states.Length / 2; i++)
            {
                temp = states[i];
                states[i] = states[states.Length - 1 - i];
                states[states.Length - 1 - i] = temp;
            }
            //01_01_01_02_遍历输出反转后的字符数组
            for (int i = 0; i < states.Length; i++)
            {
                Console.WriteLine(states[i]);
            }
        }
    }
}
