using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_外部设备案例
{
    public class UDisk:StorageDevice

    {
        public override void Read()
        {
            Console.WriteLine("U盘读取中....");
        }

        public override void Write()
        {
            Console.WriteLine("U盘写入中....");
        }
    }
}
