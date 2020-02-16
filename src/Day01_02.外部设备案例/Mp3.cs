/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月16日 星期日 14:08:58
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day01_02.外部设备案例
{
    /// <summary>
    /// 03.Mp3子类继承StorageDevice并重写读写方法
    /// </summary>
    public class Mp3:StorageDevice
    {
        public override void Read()
        {
            Console.WriteLine("Mp3读取中...");
        }

        public override void Write()
        {
            Console.WriteLine("Mp3写入中...");
        }

        /// <summary>
        /// 04.Mp3子类自己独有PlayMusic的方法
        /// </summary>
        public void PlayMusic()
        {
            Console.WriteLine("苍茫的天涯,...,我的爱...");
        }
    }
}
