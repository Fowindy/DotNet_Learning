using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_猜拳
{
    public class Player
    {
        //1.玩家首先应该有一个存储出拳内容的属性
        public string PlayerFistName { get; set; }

        //2.玩家应该有一个玩游戏的行为(方法),拿到出拳的内容
        //---将出拳内容转换成数字返回给裁判
        public int PlayerPlay(string fistName)
        {
            //将玩家出拳的内容赋值给属性
            this.PlayerFistName = fistName;

            //定义玩家出拳内容转换数字变量
            int playerNum = 0;

            //判断玩家出拳内容,并将内容按规矩转换为数字
            //石头---1
            //剪刀---2
            //布---3
            switch (this.PlayerFistName)
            {
                case "石头": playerNum = 1;
                    break;
                case "剪刀": playerNum = 2;
                    break;
                case "布": playerNum = 3;
                    break;
            }

            return playerNum;
        }

    }
}
