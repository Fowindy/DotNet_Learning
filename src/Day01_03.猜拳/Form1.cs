/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月16日 星期日 15:55:40
 * ==============================================================================*/
using Day01_03.猜拳;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day01_03.猜拳
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 05.玩家按钮触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///<![CDATA[05.01.石头按钮事件验证完成]]>
        ///<![CDATA[05.02.三个按钮绑定到一个按钮触发分析:
        ///05.02.01.首先将剪刀和布按钮触发事件绑定到石头按钮上;]]>
        private void btnStone_Click(object sender, EventArgs e)
        {
            ///<![CDATA[05.02.02.将sender对象强转为Button对象,sender表示谁触发我,我就是谁]]>
            Button button = sender as Button;
            PlayGame(button.Text);
        }
        /// <summary>
        /// 05.02.03.封装成方法
        /// </summary>
        /// <param name="fistName"></param>
        private void PlayGame(string fistName)
        {
            this.lblPlayerResult.Text = fistName;
            Player player = new Player();
            player.FistName = fistName;
            Computer computer = new Computer();
            Judge judge = new Judge();
            this.lblResult.Text = judge.JudgeWin(player.Play(player.FistName), computer.Play());
            this.lblComputerResult.Text = computer.FirstName;
        }
    }
}
