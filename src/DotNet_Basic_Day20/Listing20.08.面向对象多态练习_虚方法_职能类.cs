using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_08
{
    public class Employee
    {
        public virtual void DaKa()
        {
            Console.WriteLine("员工九点打卡");
        }
    }
    /// <summary>
    /// 经理也属于员工,只是打卡的时间和员工不一样,所以经理继承员工,需要重写员工打卡的方法,因此员工打卡的方法标记为虚方法
    /// </summary>
    public class Manager : Employee
    {
        public override void DaKa()
        {
            Console.WriteLine("经理十一点打卡");
        }
    }

    public class Programmer : Employee
    {
        public override void DaKa()
        {
            Console.WriteLine("程序猿不打卡");
        }
    }
    public class Program
    {
        public static void Main()
        {
            //作业:员工类、部门经理类 程序猿类
            //（部门经理也是员工，所以要继承自员工类。员工有上班打卡的方法。用类来模拟。

            //实例化完成
            Employee employee = new Programmer();/*new Manager();*//*new Employee();*/
            employee.DaKa();
        }
    }
}
