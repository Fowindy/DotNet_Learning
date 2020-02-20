/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月20日 星期四 23:58:43
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.Day03_02.集合.Listing01_04
{
    public class Listing01_04
    {
        public static void Main()
        {
            List<int> list = new List<int>();
            //01_循环终止条件_生成10个数
            while (list.Count < 10)
            {
                //02_调用Random函数生成1-100之间的整数
                int num = new Random().Next(1, 101);
            }
        }
    }
}
