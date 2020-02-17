/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月17日 星期一 13:46:02
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day01_05_Lib_Calculate
{
    //02.01.子类继承父类,重写父类抽象方法
    public class Add:JiSuan
    {
        //当你调用子类构造函数的时候,将子类num1,num2传到父类中去了
        public Add(int num1, int num2) : base(num1, num2)
        {
        }
        //父类抽象方法在子类中有关联
        public override int GetResult()
        {
            //可以如下写法:
            //return this.Num1 + this.Num2;
            //传入父类后,正好是父类的,等价于如下写法:
            return base.Num1 + base.Num2;
        }
    }
}
