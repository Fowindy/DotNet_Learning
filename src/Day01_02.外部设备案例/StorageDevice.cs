/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月16日 星期日 13:48:34
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day01_02.外部设备案例
{
    /// <summary>
    /// 移动存储设备父类_父类需抽象给子类继承
    /// </summary>
    public abstract class StorageDevice
    {
        /// <summary>
        /// 移动存储设备的读取
        /// </summary>
        public abstract void Read();
        /// <summary>
        /// 移动存储设备的写入
        /// </summary>
        public abstract void Write();
    }
}
