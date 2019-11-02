using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_13
{
    public class Program
    {
        public static void Main()
        {
            //1.字符串的不可变性;
            string s1 = "张三";
            s1 = "李四";//表面上是赋值,实际上在内存中又开辟了一段内存空间;"张三"还在,只是没有变量指向它,成了垃圾数据;最终会被垃圾回收机制GC回收;
            //GC:垃圾回收机制,当程序结束之后,GC会扫描整个内存空间,发现垃圾数据则回收;
            //有些资源GC是不能帮助回收的,比如FileStream(文件流),我们写在Using中
        }
    }
}
