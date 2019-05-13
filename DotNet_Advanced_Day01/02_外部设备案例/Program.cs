using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_外部设备案例
{
    class Program
    {
        static void Main(string[] args)
        {
            //先实例化一台电脑
            Computer cp = new Computer();
            #region 第一种方式
            //再实例化一个移动存储设备
            //备注:因SD为抽象父类,可以new所有的子类;子类赋值给父类
            //cp.SD = new UDisk();//new MP3();
            //调用电脑读取的方法:
            //cp.ComputerRead();
            //调用电脑写入的方法:
            //cp.ComputerWrite(); 
            #endregion

            GetDisk(new MP3());
            Console.ReadKey();
        }

        private static void GetDisk(StorageDevice sd)
        {
            if (sd is MP3)
            {
                MP3 mp3 = sd as MP3;
                mp3.Read();
                mp3.Write();
                mp3.PlayMusic();
            }
        }
    }
}
