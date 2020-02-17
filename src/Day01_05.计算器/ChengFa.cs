/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月17日 星期一 16:18:17
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
///<![CDATA[06.01.乘法类中引用命名空间]]>
using Day01_05_Lib_Calculate;

namespace Day01_05.计算器
{
    /// <summary>
    /// 06.02.子类继承父类,重写父类抽象方法
    /// </summary>
    public class ChengFa:JiSuan
    {
        public ChengFa(int num1, int num2) : base(num1, num2)
        {
        }
        public override int GetResult()
        {
            return base.Num1 * base.Num2;
        }
    }
}
