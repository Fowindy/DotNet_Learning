/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2019年11月8日 星期五 08:07:51
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Fowindy.DotNet_Basic_Day21.Listing21_06
{
    public class Listing21_06
    {
        public static void Main()
        {
            #region #6.将对象序列化成二进制
            //要将序列化对象的类,标记为可以被序列化的
            Person p = new Person();
            p.Name = "张三";
            p.Age = 18;
            p.Gender = '男';

            //把p对象序列化成二进制
            using (FileStream fsWrite = new FileStream(@"C:\Users\Administrator\Desktop\传智播客C#案例资料\Day21\序列化.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                //创建二进制转换对象
                BinaryFormatter bf = new BinaryFormatter();
                //序列化
                bf.Serialize(fsWrite, p);
            }
            Console.WriteLine("序列化成功!"); 
            #endregion
        }
    }
    //如果想将此类序列化成对象的话,需要标记此类可序列化
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
    }
}
