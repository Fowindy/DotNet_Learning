/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月28日 星期五 23:46:22
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Day03_08.StreamReader和StreamWriter
{
    public class Program
    {
        static void Main(string[] args)
        {
            //01_创建一个StreamReader对象读取目标文件
            using (StreamReader sr = new StreamReader("../../../相关资料/1.txt",Encoding.Default))
            {
                //01_01_Read方法貌似在读_但是返回不了需要的内容_弃用
                //sr.Read()
                //01_02_使用ReadLine方法读取_能获取内容_只能读取单行_解决乱码问题_推荐
                //string line = sr.ReadLine();
                //Console.WriteLine(line);
                //01_03_读取多行完整内容_读取不为空则循环读取_推荐
                string line = null;
                //while ((line = sr.ReadLine()) != null)
                //{
                //    Console.WriteLine(line);
                //}
                Console.WriteLine("----------------01_04_第三种读取方式_读取流直到末尾----------------");
                line = sr.ReadToEnd();
                Console.WriteLine(line);
            }
            //02_创建一个StreamWriter写入文件流对象
            using (StreamWriter sw = new StreamWriter("../../../相关资料/2.txt"))
            {
                //02_01_文本中写入字符
                sw.Write("哈哈,出师未捷身先死,长使英雄泪满襟");
            }
            //03_读写文件方式总结
            Console.ReadKey();
        }
    }
}
