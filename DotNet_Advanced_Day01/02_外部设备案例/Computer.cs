using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_外部设备案例
{
    public class Computer
    {
        //电脑从移动存储设备中读取
        //定义移动存储设备的自动属性
        public StorageDevice SD { get; set; }

        //电脑读取的方法
        public void ComputerRead()
        {
            //SD作为抽象父类,实际调用的是子类的方法
            SD.Read();
        }
        //电脑写入的方法
        public void ComputerWrite()
        {
            SD.Write();
        }
    }
}
