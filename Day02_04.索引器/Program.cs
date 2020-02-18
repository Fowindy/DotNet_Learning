/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月18日 星期二 15:50:01
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day02_04.索引器
{
    public class Program
    {
        static void Main(string[] args)
        {
            //02_实例化Person对象,只能通过.来调用,不能通过索引
            Person person = new Person();
            //person.Name = "张三";
        }
    }
    //01_声明Person类并定义Name_Age属性
    public class Person
    {
        //public string Name { get; set; }
        //public int Age { get; set; }
        //02_01_定义Names字符数组
        public string[] Names = { "yzk", "sk", "ml", "jk" };
    }
}
