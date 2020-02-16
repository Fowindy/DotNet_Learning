/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月16日 星期日 17:21:41
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day01_03.猜拳
{
    public class Computer
    {
        /// <summary>
        /// 03.01.定义记录电脑出拳内容的属性
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// 03.02.电脑出拳的方法并将随机整数转换为出拳内容
        /// </summary>
        /// <returns></returns>
        ///<![CDATA[注意:电脑出拳的内容是随机数,不需要转换,因此无参数]]>
        public int Play()
        {
            int num = new Random().Next(1, 4);
            //将随机整数转换为出拳内容
            switch (num)
            {
                case 1: FirstName = "石头";break;
                case 2: FirstName = "剪刀";break;
                case 3:FirstName = "布";break;
            }
            return num;
        }
    }
}
