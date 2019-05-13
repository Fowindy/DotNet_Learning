using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_登记案例
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 第一种登记方式,不推荐
            //Person person = new Person();
            //person.DengJi();
            //person.SayHello();

            //Car car = new Car();
            //car.DengJi();

            //Student student = new Student();
            //student.SayHello();
            //student.DengJi();

            //House house = new House();
            //house.DengJi(); 
            #endregion

            #region 第二种方式,推荐
            //IDengJi dj = new Car()/*new Student()*//*new House()*/;
            //dj.DengJi(); 
            #endregion

            #region 登记第三种方式,强力推荐
            GetDengJi(new Student());
            GetDengJi(new Car());
            GetDengJi(new House()); 
            #endregion
            Console.ReadKey();
        }

        public static void GetDengJi(IDengJi dj)
        {
            //如果每一个子类中的方法都不一样,并且没有重写,才需要判断
            
            //可以省略
            //if (dj is Student)
            //{
            //    dj = new Student();
            //}
            //else if (dj is Car)
            //{
            //    dj = new Car();
            //}
            //else if (dj is House)
            //{
            //    dj = new House();
            //}
            dj.DengJi();
        }
    }
}
