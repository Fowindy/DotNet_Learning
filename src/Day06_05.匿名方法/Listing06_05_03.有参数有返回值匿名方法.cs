/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月27日 星期日 22:29:49
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月27日 星期日 22:29:49
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace Fowindy.Day06_05.匿名方法.Listing06_05_03
{
    public class Listing06_05_03
    {
        /// <summary>
        /// 定义有参数有返回值的委托
        /// </summary>
        /// <param name="num1">参数1</param>
        /// <param name="num2">参数2</param>
        /// <returns>返回结果</returns>
        public delegate int MyDelGetSum(int num1,int num2);
        public static void Main()
        {
            MyDelGetSum myDelGetSum = delegate (int num1, int num2) { return num1 + num2; };
            int sum = myDelGetSum(10, 15);
            Console.WriteLine(sum);
        }
    }
}
