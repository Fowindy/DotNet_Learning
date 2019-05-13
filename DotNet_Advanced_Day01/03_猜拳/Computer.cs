using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_猜拳
{
    public class Computer
    {
        //1.电脑有一个属性记录电脑出拳的内容
        public string ComputerFistName { get; set; }

        //2.电脑玩的行为(方法),电脑随机出拳,因此无需传参
        //电脑将随机出的数字转换为出拳内容
        public int ComputerPlay()
        {
            //创建随机数种子
            Random r = new Random();
            int computerNum = r.Next(1, 4);
            //将出拳数字转换为出拳内容
            switch (computerNum)
            {
                case 1: this.ComputerFistName = "石头";
                    break;
                case 2: this.ComputerFistName = "剪刀";
                    break;
                case 3:this.ComputerFistName = "布";
                    break;
            }
            return computerNum;
        }
    }
}
