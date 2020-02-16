/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月16日 星期日 22:33:38
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day01_04.登记案例
{
    public class Program
    {
        static void Main(string[] args)
        {
            //02.02.通过人继承接口实现登记功能
            Person person = new Person();
            person.DengJi();
            //03.02.通过车继承接口实现登记功能
            Car car = new Car();
            car.DengJi();
            Console.ReadKey();
        }
    }
}
