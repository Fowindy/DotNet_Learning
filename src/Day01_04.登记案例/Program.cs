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
            person.DengJi();//人登记了
            //03.02.通过车继承接口实现登记功能
            Car car = new Car();
            car.DengJi();//车登记了
            //04.02.学生类通过继承人类(本身继承登记),最终学生也继承了登记方法_不完美
            Student student = new Student();
            student.DengJi();//人登记了
            Console.ReadKey();
        }
    }
}
