/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月16日 星期日 22:54:25
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day01_04.登记案例
{
    /// <summary>
    /// 02.01.Person类继承IDengJi登记接口
    /// </summary>
    public class Person
    {
        //解除Person类与接口的关系
        public void SayHello()
        {
            Console.WriteLine("我是人类");
        }
    }
}
