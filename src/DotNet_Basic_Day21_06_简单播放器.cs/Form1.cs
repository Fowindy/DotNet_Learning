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
            //$7.3.在程序加载的时候,取消播放器默认的自动播放功能_成功_先取消自动播放,后对URL赋值
            MusicPlayer.URL = @"C:\Users\Administrator\Desktop\传智播客C#案例资料\Day21\简单播放器\周杰伦 - 给我一首歌的时间.mp3";
        }
        /// <summary>
        /// $7.5.一个按钮实现播放暂停切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayOrPause_Click(object sender, EventArgs e)
        {
            //显示播放,点击的目的则是播放,同时将按钮显示为暂停
            if (btnPlayOrPause.Text == "播放")
            {
                MusicPlayer.Ctlcontrols.play();
                btnPlayOrPause.Text = "暂停";
            }
            else
            {
                MusicPlayer.Ctlcontrols.pause();
                btnPlayOrPause.Text = "播放";
            }
        }
    }
}
