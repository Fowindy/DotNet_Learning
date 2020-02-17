/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月17日 星期一 13:58:56
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day01_05_Lib_Calculate
{
    public class Sub:JiSuan
    {
        //构造函数必须写,不写构造函数,数值成员没有办法传进来
        public Sub(int num1, int num2) : base(num1, num2)
        {
        }
        public override int GetResult()
        {
            //因为给Sub类是父类的一个子类,这个属性是父类的,被子类继承
            return this.Num1 - this.Num2;
        }
    }
}
