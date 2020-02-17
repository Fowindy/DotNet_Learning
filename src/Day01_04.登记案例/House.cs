/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月16日 星期日 23:45:18
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day01_04.登记案例
{
    //05.01.通过房子继承接口实现登记功能
    //可以把接口看成一个特殊的类,可以通过父类new出子类对象
    public class House:IDengJi
    {
        public void DengJi()
        {
            Console.WriteLine("房子登记了");
        }
    }
}
