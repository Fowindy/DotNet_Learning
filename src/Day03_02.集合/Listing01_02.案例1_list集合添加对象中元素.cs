/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月20日 星期四 21:19:23
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.Day03_02.集合.Listing01_02
{
    public class Listing01_02
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();
            //01_02_02_往list集合中添加成员信息
            people.Add(new Person() { Name = "张三", Age = 18, Gender = '男' });
            people.Add(new Person() { Name = "李四", Age = 38, Gender = '女' });
            people.Add(new Person() { Name = "王五", Age = 28, Gender = '男' });
        }
    }
    //01_02_01_声明一个Person类并定义相关属性
    public class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private char _gender;

        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

    }

}
