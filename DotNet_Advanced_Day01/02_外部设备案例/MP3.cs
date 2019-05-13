using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_外部设备案例
{
    public class MP3:StorageDevice
    {
        public override void Read()
        {
            Console.WriteLine("MP3读取中....");
        }

        public override void Write()
        {
            Console.WriteLine("MP3写入中....");
        }

        public void PlayMusic()
        {
            Console.WriteLine("MP3可以播放音乐....");
        }
    }
}
