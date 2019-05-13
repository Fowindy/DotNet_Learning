using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_猜拳
{
    public class Judge
    {
        //裁判拿到两者出拳的数字量化结果,进行计算,得出输赢结果

        /*
         玩家     电脑      差值
         石头1    石头1     
         剪刀2    剪刀2
         布3      布3

         0      -----   平
         1-2=-1         玩家赢
         1-3=-2         玩家输
         2-1=1          玩家输
         2-3=-1         玩家赢
         3-1=2          玩家赢
         3-2=1          玩家输
             */
        public string Win(int playerNum,int computerNum)
        {
            if (playerNum - computerNum == 0)
            {
                return "你们两个棋逢对手!平了";
            }
            else if (playerNum - computerNum == 2 || playerNum - computerNum == -1)
            {
                return "玩家赢了,你太牛X了!";
            }
            else
            {
                return "玩家输了,电脑太厉害了!";
            }
        }
    }
}
