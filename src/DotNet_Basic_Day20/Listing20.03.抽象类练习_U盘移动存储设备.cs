﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fowindy.DotNet_Basic_Day20.Listing20_03
{
    /// <summary>
    /// 抽象移动存储设备父类
    /// </summary>
    public abstract class MobileStorage
    {
        /// <summary>
        /// 抽象_读方法
        /// </summary>
        public abstract void Read();
        /// <summary>
        /// 抽象_写方法
        /// </summary>
        public abstract void Write();
    }

    public class MobileDisk:MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘在读取数据...");
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘在写入数据...");
        }
    }

    public class UDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("U盘在读取数据...");
        }

        public override void Write()
        {
            Console.WriteLine("U盘在写入数据...");
        }
    }

    /// <summary>
    /// 电脑类
    /// </summary>
    ///<![CDATA[电脑类思路:
    ///电脑不知道哪一个设备会插在电脑上,因此只能对存储设备父类进行处理;__屏蔽各个子类间的差异;
    ///#有两种方式实现:
    ///#1.通过传参的方式将父类传进来;
    ///#2.在电脑类中声明父类类型的属性;]]>
    public class Computer
    {
        public MobileStorage MS { get; set; }
        public void Read()
        {
            this.MS.Read();
        }

        public void Write()
        {
            this.MS.Write();
        }
    }

    public class Mp3 : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("Mp3在读取数据...");
        }

        public override void Write()
        {
            Console.WriteLine("Mp3在写入数据...");
        }

        public void PlayMusic()
        {
            Console.WriteLine("Mp3有自己播放音乐的方法");
        }
    }
    public class Program
    {
        public static void Main()
        {
            #region 移动存储设备的实例化
            MobileDisk mobileDisk = new MobileDisk();
            UDisk uDisk = new UDisk();
            Mp3 mp3 = new Mp3();
            #endregion

            Computer computer = new Computer();
            //子类可以赋值给父类;相当于将移动存储设备插到了电脑上
            //只需要更改此处就可以实现不同移动存储设备插在电脑上的动作
            computer.MS = mp3/*mobileDisk*/;
            computer.Read();
            computer.Write();
        }
    }
}
