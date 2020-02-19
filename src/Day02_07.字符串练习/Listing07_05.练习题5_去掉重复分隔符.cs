/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月19日 星期三 21:45:11
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.Day02_07.字符串练习.Listing07_05
{
    public class Listing07_05
    {
        public static void Main()
        {
            //练习5：123-456---7---89-----123----2把类似的字符串中重复符号”-”去掉，既得到123-456-7-89-123-2
            string str = "123-456---7---89-----123----2";
            //07_05_01_先去除分隔符得到字符数组
            string[] strs = str.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

        }
    }
}
