/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月29日 星期二 00:10:42
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月29日 星期二 00:10:42
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Reflection;

namespace Fowindy.Day06_12.程序集.Listing06_12_01
{
    public class Listing06_12_01
    {
        public static void Main()
        {
            Person person = new Person();
            //获取person的Type
            Type type = person.GetType();
            //获取当前type对象的所有的公共的方法
            MethodInfo[] meths = type.GetMethods();
            //遍历所有的方法
            for (int i = 0; i < meths.Length; i++)
            {
                //打印方法的名字
                Console.WriteLine(meths[i].Name);
            }
            //获取所有的公共属性
            PropertyInfo[] pros = type.GetProperties();
            //遍历所有的公共属性
            for (int i = 0; i < pros.Length; i++)
            {
                Console.WriteLine(pros[i].Name);
            }
            //类中可有哪些成员?
            //1.属性
            //2.字段
            //3.方法
            //4.事件
            //5.接口 等等
            //都可以通过这种方式获取
        }
    }
    public class Person
    {
        //字段就是变量
        private int _age;
        //属性就是方法;Get方法和Set方法
        public int Age { get => _age; set => _age = value; }
        public void Say()
        {
            Console.WriteLine("我是人,需要吃饭!");
        }
    }
}
