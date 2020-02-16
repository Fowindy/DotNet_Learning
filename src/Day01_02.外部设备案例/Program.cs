using System;

namespace Day01_02.外部设备案例
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<![CDATA[11.电脑读写移动硬盘的功能实现]]>
            Computer computer = new Computer();
            ///<![CDATA[12.给computer实例移动存储设备属性赋值实例化]]>
            computer.SD = new Mp3();
            ///<![CDATA[13.电脑调用读写方法]]>
            computer.CpuRead();
            computer.CpuWrite();
        }
    }
}
