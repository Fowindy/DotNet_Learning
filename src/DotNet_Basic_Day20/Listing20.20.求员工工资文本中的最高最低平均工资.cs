using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_20
{
    public class Program
    {
        public static void Main()
        {
            //练习7.求员工工资文本中的最高最低平均工资
            //首先声明一个字符数组从文件中读到内容
            string[] strNew = File.ReadAllLines(@"J:\Documents\Source\Repos\DotNet_Learning\DotNet_Basic_Class\src\DotNet_Basic_Day20\20.20.员工工资附件\员工工资.txt", Encoding.Default);
            int max = int.MinValue;
            int min = int.MaxValue;
            double sum = 0;
            for (int i = 0; i < strNew.Length; i++)
            {
                max = int.Parse(strNew[i].Split(',',StringSplitOptions.RemoveEmptyEntries)[1]) >= max? int.Parse(strNew[i].Split(',', StringSplitOptions.RemoveEmptyEntries)[1]):max;
                min = int.Parse(strNew[i].Split(',',StringSplitOptions.RemoveEmptyEntries)[1]) <= min? int.Parse(strNew[i].Split(',', StringSplitOptions.RemoveEmptyEntries)[1]):min;
                sum += int.Parse(strNew[i].Split(',', StringSplitOptions.RemoveEmptyEntries)[1]);
            }
            Console.WriteLine("最高工资为:{0};最低工资为:{1};平均工资为:{2}",max,min,sum/strNew.Length);
        }
    }
}
