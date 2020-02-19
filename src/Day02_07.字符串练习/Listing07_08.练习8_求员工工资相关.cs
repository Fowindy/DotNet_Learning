/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月19日 星期三 23:27:14
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Fowindy.Day02_07.字符串练习.Listing07_08
{
    public class Listing07_08
    {
        public static void Main()
        {
            //练习8.求员工工资文件中，员工的最高工资、最低工资、平均工资
            string[] lines = File.ReadAllLines("../../../相关资料/salary.txt", Encoding.Default);
            int max = int.MinValue;
            int min = int.MaxValue;
            double average = 0;
            double sum = 0;
            //07_08_02_截取字符串获取工资数据
            for (int i = 0; i < lines.Length; i++)
            {
                int salary = int.Parse(lines[i].Split('=', StringSplitOptions.RemoveEmptyEntries)[1]);
                if (salary > max)
                {
                    max = salary;
                }
                if (salary < min)
                {
                    min = salary;
                }
                sum += salary;
            }
            average = sum / lines.Length;
            Console.WriteLine("员工最高工资为:{0},最低工资为:{1},平均工资为:{2}", max, min, average);
        }
    }
}
