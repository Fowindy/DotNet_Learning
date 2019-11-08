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
            //要将序列化对象的类,标记为可以被序列化的
            Person p = new Person();
#if false
            #region $6.1.将对象序列化成二进制
            //把p对象序列化成二进制
            using (FileStream fsWrite = new FileStream(@"C:\Users\Administrator\Desktop\传智播客C#案例资料\Day21\序列化.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                p.Name = "张三";
                p.Age = 18;
                p.Gender = '男';
                //创建二进制转换对象
                BinaryFormatter bf = new BinaryFormatter();
                //序列化
                bf.Serialize(fsWrite, p);
            }
            Console.WriteLine("序列化成功!");
            #endregion  
#endif

            #region $6.2.将二进制反序列化成对象
            using (FileStream fsRead = new FileStream(@"C:\Users\Administrator\Desktop\传智播客C#案例资料\Day21\序列化.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                //创建二进制转换对象
                BinaryFormatter bf = new BinaryFormatter();
                //反序列化成object对象_因为知道是Person
                p = (Person)bf.Deserialize(fsRead);
                Console.WriteLine("反序列化成功");
                Console.WriteLine(p.Name);
                Console.WriteLine(p.Age);
                Console.WriteLine(p.Gender);
            }
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
