using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_17
{
    public class Program
    {
        public static void Main()
        {
            //课上练习4：”2019年11月03日”从日期字符串中把年月日分别取出来，打印到控制台
            string date = "2019年11月03日";
            //分隔字符串,去掉年月日
            string[] dateNew = date.Split(new char[] { '年', '月', '日' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("年:{0},月:{1},日:{2}",dateNew[0],dateNew[1],dateNew[2]);
        }
    }
}
