/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月16日 星期日 14:34:55
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day01_02.外部设备案例
{
    /// <summary>
    /// 06.移动硬盘MobileDisk子类继承StorageDevice父类
    /// </summary>
    public class MobileDisk:StorageDevice
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘读取中...");
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘写入中...");
        }
    }
}
