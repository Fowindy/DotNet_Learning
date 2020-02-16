/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月16日 星期日 14:43:40
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day01_02.外部设备案例
{
    /// <summary>
    /// 07.Computer类_电脑从移动存储设备中读取
    /// </summary>
    public class Computer
    {
        /// <summary>
        /// 08.定义移动存储设备的自动属性
        /// </summary>
        public StorageDevice SD { get; set; }

        /// <summary>
        /// 09.定义电脑接收移动存储设备读取的方法
        /// </summary>
        public void CpuRead()
        {
            ///<![CDATA[SD是抽象父类,实际调用的是子类]]>
            SD.Read();
        }
    }
}
