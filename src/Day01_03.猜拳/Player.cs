/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月16日 星期日 17:03:08
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day01_03.猜拳
{
    public class Player
    {
        /// <summary>
        /// 02.01.定义记录玩家出拳的内容的属性
        /// </summary>
        public string FistName { get; set; }
        /// <summary>
        /// 02.02.创建玩家出拳的方法
        /// </summary>
        /// <returns></returns>
        public int Play(string fistName)
        {
            //02.03.将玩家出拳的内容赋值给属性
            this.FistName = fistName;
        }
    }
}
