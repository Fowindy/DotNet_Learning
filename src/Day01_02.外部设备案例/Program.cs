using System;

namespace Day01_02.外部设备案例
{
    class Program
    {
        static void Main(string[] args)
        {
            /////<![CDATA[11.电脑读写移动硬盘的功能实现]]>
            //Computer computer = new Computer();
            /////<![CDATA[12.给computer实例移动存储设备属性赋值实例化]]>
            //computer.SD = new Mp3();//new UDisk();
            /////<![CDATA[13.电脑调用读写方法]]>
            //computer.CpuRead();
            //computer.CpuWrite();
            /////<![CDATA[14.Mp3自己播放音乐的方法_需要重新实例化Mp3对象获取]]>
            //Mp3 mp3 = new Mp3();
            //mp3.PlayMusic();

            ///<![CDATA[15.电脑读写移动硬盘的功能实现2]]>
            GetDisk(new Mp3());
            Console.ReadKey();
        }

        private static void GetDisk(StorageDevice SD)
        {
            ///<![CDATA[16.判断是否为Mp3,如果为Mp3则把父类转为子类]]>
            if (SD is Mp3)
            {
                Mp3 mp3 = SD as Mp3;
                mp3.Read();
                mp3.Write();
                mp3.PlayMusic();
            }
        }
    }
}
