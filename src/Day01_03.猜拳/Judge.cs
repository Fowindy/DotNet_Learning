/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月16日 星期日 17:51:31
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day01_03.猜拳
{
    public class Judge
    {
        ///<![CDATA[04.01.裁判判决的方法分析如下:
        ///总体方法:裁判拿到两者出拳的数字量化结果,进行计算,得出输赢结果;
        ///玩家              电脑              量化差值                输赢结果
        ///出拳一样          出拳一样               0                     平
        ///石头:1            剪刀:2                -1                  玩家赢
        ///石头:1            布:3                  -2                  电脑赢
        ///剪刀:2            布:3                  -1                  玩家赢
        ///剪刀:2            石头:1                 1                  电脑赢
        ///布:3              石头:1                 2                  玩家赢
        ///布:3              剪刀:2                 1                  电脑赢
        ///分析结果如下:
        ///玩家赢的量化差值为:-1和2
        ///电脑赢的量化差值为:-2和1
        ///平局的量化差值为:0]]>
        
        ///<![CDATA[04.02.裁判判决输赢的方法]]>
        public string JudgeWin(int playerNum,int computerNum)
        {
            if (playerNum - computerNum == 0)
            {
                return "你们两个棋逢对手!平了";
            }
            else if (playerNum - computerNum == -1 || playerNum - computerNum == 2)
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
