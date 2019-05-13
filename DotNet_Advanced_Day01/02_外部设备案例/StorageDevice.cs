using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_外部设备案例
{
    /// <summary>
    /// 移动存储设备父类
    /// </summary>
    public abstract  class StorageDevice
    {
        /// <summary>
        /// 移动存储设备读取的方法
        /// </summary>
        public abstract void Read();

        /// <summary>
        /// 移动存储设备写入的方法
        /// </summary>
        public abstract void Write();
    }
}
