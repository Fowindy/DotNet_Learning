/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月16日 星期日 14:23:00
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day01_02.外部设备案例
{
    /// <summary>
    /// 05.U盘子类继承StorageDevice父类
    /// </summary>
    public class UDisk:StorageDevice
    {
        public override void Read()
        {
            Console.WriteLine("U盘读取中...");
        }

        public override void Write()
        {
            Console.WriteLine("U盘写入中...");
        }
    }
}
