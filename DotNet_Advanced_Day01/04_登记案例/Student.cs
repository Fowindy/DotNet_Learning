using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_登记案例
{
    //04_登记案例_知识点2_学生同时继承父类和接口(父类在前,接口在后)
    public class Student:Person,IDengJi
    {
        public void DengJi()
        {
            Console.WriteLine("学生登记了");
        }
    }
}
