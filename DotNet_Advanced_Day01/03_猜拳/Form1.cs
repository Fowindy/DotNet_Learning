using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_猜拳
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStone_Click(object sender, EventArgs e)
        {
            //将触发事件强转为按钮
            //sender表示谁触发我,我就是谁
            Button btn = (Button)sender;

            //封装成方法
            PlayGame(btn.Text);
        }

        private void PlayGame(string fistName)
        {
            //点击按钮开始玩游戏
            //1.首先创建一个玩家
            Player player = new Player();
            //2.玩家开始出拳
            int playerNum = player.PlayerPlay(fistName);
            //3.将玩家出拳的内容显示在lab控件上
            labPlayerResult.Text = player.PlayerFistName;

            //4.创建一个电脑
            Computer computer = new Computer();
            //5.电脑开始出拳
            int computerNum = computer.ComputerPlay();
            //5.将电脑出拳的内容显示在label控件上
            labComputerResult.Text = computer.ComputerFistName;

            //5.创建一个裁判
            Judge judge = new Judge();
            //6.将输赢的结果显示在label控件上
            labWinResult.Text = judge.Win(playerNum,computerNum);
        }
    }
}
