/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月17日 星期一 23:02:46
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day02_01.this的一种用法
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        //01.新增类不建议写(嵌套类)在主类里面
        //public class Person
        //{
        //}
    }
    //02.新增Person类
    public class Person
    {
        //02.01.定义姓名,年龄属性
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
