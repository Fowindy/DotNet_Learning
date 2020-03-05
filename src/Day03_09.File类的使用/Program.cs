/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年3月5日 星期四 11:41:21
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Day03_09.File类的使用
{
    public class Program
    {
        static void Main(string[] args)
        {
            //01_AppendAllText_向文本中追加内容
            File.AppendAllText("../../../相关资料/1.txt","哈哈哈");
            //02_Create_创建文件_等同于FileStream对象
            //File.Create("../../../相关资料/t.txt");
            //FileStream fileStream = new FileStream("../../../相关资料/t.txt", FileMode.Create, FileAccess.ReadWrite);
            //03_Delete删除文件_如文件不存在不报异常
            File.Delete("../../../相关资料/t.txt");
            //04_Exists判断文件是否存在_返回bool类型
            Console.WriteLine(File.Exists("../../../相关资料/1.txt"));
            //05_Move移动文件_相当于剪切
            //File.Move("../../../相关资料/1.txt", "../../../相关资料/2.txt");
            //06_ReadAllLines读取每一行并返回行数组
            string[] lines = File.ReadAllLines("../../../相关资料/2.txt");
            //07_ReadAllText读取每一行并返回字符串
            string line = File.ReadAllText("../../../相关资料/2.txt");
            //08_WriteAllLines往文件中写入字符串数组_覆盖
            File.WriteAllLines("../../../相关资料/1.txt", lines);
            Console.ReadKey();
        }
    }
}
