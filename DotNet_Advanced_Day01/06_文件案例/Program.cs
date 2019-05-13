using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_文件案例
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请您输入文件:");
            string str = Console.ReadLine();
            //获取文件的后缀名
            //判断后缀名是什么？

            UserFile uf = GetShow(str);
            if (uf != null)
            {
                uf.Show();
                Console.ReadKey();
            }
        }
        //简单工厂模式
        private static UserFile GetShow(string fileName)
        {
            UserFile uf = null;
            switch (Path.GetExtension(fileName).ToLower())
            {
                case ".txt":uf = new TxtFile(fileName);break;
                case ".xml":uf = new XmlFile(fileName);break;
                case ".avi":uf = new AviFile(fileName);break;
            }
            return uf;
        }
    }
}
