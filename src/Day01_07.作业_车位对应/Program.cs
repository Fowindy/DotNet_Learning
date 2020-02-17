/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月17日 星期一 20:47:59
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day01_07.作业_车位对应
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入您的车的品牌:");
            string brand = Console.ReadLine();
            Car car = GetCarBrand(brand);
            if (car != null)
            {
                car.GetCarGarage();
            }
            Console.ReadKey();  
        }

        private static Car GetCarBrand(string brand)
        {
            Car car = null;
            switch (brand)
            {
                case "宝马":car=new BMW(brand); break;
                case "奔驰":car = new Benz(brand);break;
                case "奥迪":car = new Audi(brand);break;
                case "兰博基尼":car = new Lamborghini(brand);break;
            }
            return car;
        }
    }
}
