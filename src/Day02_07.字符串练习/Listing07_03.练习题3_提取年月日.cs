/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月19日 星期三 19:31:25
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.Day02_07.字符串练习.Listing07_03
{
    public class Listing07_03
    {
        public static void Main()
        {
            //题目:从日期"2012年12月21日"字符串中把年月日分别提取出来,打印到控制台
            string str = "2012年12月21日";
            //07_03_01_先将字符串用年月日隔开
            string[] strs = str.Split(new char[] { '年', '月', '日' }, StringSplitOptions.RemoveEmptyEntries);
            //07_03_02_打印到控制台
            Console.WriteLine("年:{0},月:{1},日:{2}",strs[0],strs[1],strs[2]);
        }
    }
}
