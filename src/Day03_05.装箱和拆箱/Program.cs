/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月25日 星期二 05:40:53
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day03_05.装箱和拆箱
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            //01_装箱_值类型隐式转换成引用类型_饼干放盒子里
            object obj = num;

            //02_拆箱_引用类型强制转换为值类型_饼干拿出盒子
            int n = (int)obj;
        }
    }
}
