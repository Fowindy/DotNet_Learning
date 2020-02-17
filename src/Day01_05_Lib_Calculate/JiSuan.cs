/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月17日 星期一 13:21:32
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01_05_Lib_Calculate
{
    //01.抽象出一个JiSuan的父类
    public abstract class JiSuan
    {
        //01.01.计算涉及到两个成员,定义两个成员的属性
        public int Num1 { get; set; }
        public int Num2 { get; set; }

    }
}
