/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2019年11月7日 星期四 16:18:54
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Fowindy.DotNet_Basic_Day21.Listing21_04
{
    public class Listing21_04
    {
        public static void Main()
        {
            #region $4.1.案例1:对职工工资文件处理,所有人的工资加倍然后输出到新文件
            //文件案例：
            //马大哈|3000
            //宋江|8000
            //首先读取文件中每一行的内容
            string[] str = File.ReadAllLines(@"C:\Users\Administrator\Desktop\传智播客C#案例资料\Day21\工资.txt", Encoding.Default);
            for (int i = 0; i < str.Length; i++)
            {
                //对工资加倍
                int temp = int.Parse(str[i].Split('|', StringSplitOptions.RemoveEmptyEntries)[1]) * 2;
                //整理当前行的输出内容
                str[i] = str[i].Split('|', StringSplitOptions.RemoveEmptyEntries)[0] + '|' + temp;
            }
            //将字符串数组重新写入到文件中
            File.WriteAllLines(@"C:\Users\Administrator\Desktop\传智播客C#案例资料\Day21\工资.txt", str);
            #endregion
        }
    }
}
