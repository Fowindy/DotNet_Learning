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
            //person.DengJi();//人登记了
            //03.02.通过车继承接口实现登记功能
            Car car = new Car();
            car.DengJi();//车登记了
            //04.02.学生类通过继承人类(本身继承登记),最终学生也继承了登记方法_不完美
            Student student = new Student();
            student.DengJi();//学生登记了//人登记了
            //05.02.通过房子继承接口实现登记功能
            //House house = new House();
            //house.DengJi();//房子登记了
            //05.03.可以通过接口(特殊的父类)new出子类对象方法实现
            IDengJi dengJi = new House();
            dengJi.DengJi();//房子登记了
            //05.04.登记接口的第三种实现方法,强力推荐
            Console.WriteLine("--------05.04.登记接口的第三种实现方法,强力推荐--------");
            GetDengJi(new Student());
            GetDengJi(new Car());
            GetDengJi(new House());
            Console.ReadKey();
        }
        public static void GetDengJi(IDengJi dengJi)
        {
            //如果每一个子类中的方法都不一样,并且没有重写,才需要判断
            //可以省略
            //if (dengJi is Car)
            //{
            //    dengJi = new Car();
            //}
            //else if (dengJi is Student)
            //{
            //    dengJi = new Student();
            //}
            //else if (dengJi is House)
            //{
            //    dengJi = new House();
            //}
            dengJi.DengJi();
        }
    }
}
