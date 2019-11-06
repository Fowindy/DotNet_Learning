using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_18
{
    public class Program
    {
        public static void Main()
        {
            //  练习5：123-456---789-----123-2把类似的字符串中重复符号去掉，
            //既得到123-456-789-123-2. split()、
            string str = "123-456---789-----123-2";
            //首先去除所有的-
            string[] strNew = str.Split('-', StringSplitOptions.RemoveEmptyEntries);
            str = string.Join('-', strNew);//123-456-789-123-2
            Console.WriteLine(str);
        }
    }
}
