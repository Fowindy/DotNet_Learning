/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月16日 星期日 23:19:57
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day01_04.登记案例
{
    ///<![CDATA[04.01.学生类继承人类,人类继承接口]]>
    ///<![CDATA[04.03.学生同时继承父类和接口(父类在前,接口在后)]]>
    public class Student:Person,IDengJi
    {
        public void DengJi()
        {
            Console.WriteLine("学生登记了");
        }
    }
}
