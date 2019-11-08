using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNet_Basic_Day21_06_简单播放器.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //播放按钮
        private void button1_Click(object sender, EventArgs e)
        {
            MusicPlayer.Ctlcontrols.play();
        }
        //暂停按钮
        private void button2_Click(object sender, EventArgs e)
        {
            MusicPlayer.Ctlcontrols.pause();
        }
        //停止按钮
        private void button3_Click(object sender, EventArgs e)
        {
            MusicPlayer.Ctlcontrols.stop();
        }
        /// <summary>
        /// 程序加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MusicPlayer_Enter(object sender, EventArgs e)
        {
            //$7.2.在程序加载的时候,取消播放器默认的自动播放功能_没能成功_因为Url赋值即触发播放
            MusicPlayer.settings.autoStart = false;
        }
    }
}
