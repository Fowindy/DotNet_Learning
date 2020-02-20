/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月20日 星期四 14:19:27
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.Day02_10.字符串练习2.Listing01_03
{
    public class Listing01_03
    {
        public static void Main()
        {
            string str = "传说在传智播客.net部门有个讲师叫小杨,小杨很帅,很纯洁,小杨是智慧和勇敢的化身.第一次听人这么说我不相信,于是我怀着试试看的心情来到了传智播客,见到了传说中的小杨。哇塞,小杨岂止是帅,简直就是帅的无法用言语来形容.";
            //01_03_01_定义目标字段_序标_次数
            string keyWord = "小杨";
            int index = 0;
            int count = 0;
            //01_03_02_循环遍历的条件_查找不到indexof返回-1
            while ((index = str.IndexOf(keyWord, index)) != -1)
            {
                //01_03_03_次数加1
                count++;
                //01_03_04打印
                Console.WriteLine("{0}第{1}次出现,当前索引位置为{2}", keyWord, count, index);

            }
        }
    }
}
