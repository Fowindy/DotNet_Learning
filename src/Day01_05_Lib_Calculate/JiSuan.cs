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
        //01.02.父类需要通过构造函数拿到子类的两个成员并赋值给父类属性
        ///<![CDATA[[构造函数知识点]
        ///         1.每一个类都隐式默认带一个不带参数的构造函数;
        ///         2.当显式命名一个构造函数,则不带参数的隐式构造函数就没有了;]]>
        public JiSuan(int num1, int num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
        }
        //01.03.父类中声明一个获取计算结果的抽象方法
        public abstract int GetResult();
    }
}
