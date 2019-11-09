using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            btnPlayOrPause.Text = "播放";
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
            //MusicPlayer.URL = @"C:\Users\Administrator\Desktop\传智播客C#案例资料\Day21\简单播放器\周杰伦 - 给我一首歌的时间.mp3";
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
        //声明一个泛型集合,用于音乐的路径
        List<string> listPath = new List<string>();
        /// <summary>
        /// $7.8.加载音乐对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadMusic_Click(object sender, EventArgs e)
        {
            //创建打开文件对话框的窗口
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //默认打开路径
            openFileDialog.InitialDirectory = @"C:\Users\Administrator\Desktop\传智播客C#案例资料\Day21\简单播放器\Music";
            //打开文件类型
            openFileDialog.Filter = "Mp3文件|*.mp3|Wav文件|*.wav|所有文件|*.*";
            //打开文件标题
            openFileDialog.Title = "请选择音乐文件";
            //可以多选
            openFileDialog.Multiselect = true;
            //显示对话窗口
            openFileDialog.ShowDialog();

            //获得在文本框中选择文件的全路径
            string[] path = openFileDialog.FileNames;

            #region $7.9.将音乐加载进界面显示
            //循坏将全路径加载进泛型集合
            for (int i = 0; i < path.Length; i++)
            {
                //将音乐文件的全路径存储到泛型集合中
                listPath.Add(path[i]);

                //将音乐文件的文件名存储到ListBox中
                MusicList.Items.Add(Path.GetFileName(path[i]));
            } 
            #endregion

        }
        /// <summary>
        /// $7.10.为MusicList注册双击播放事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MusicList_DoubleClick(object sender, EventArgs e)
        {
            //异常处理1:如果列表为空
            if (MusicList.Items.Count == 0)
            {
                MessageBox.Show("请首先选择音乐文件");
                //结束本次方法,不执行下面的操作
                return;
            }

            //异常处理2:当在列表空白的地方双击时,抛异常;
            //拿到双击对象的URL
            try
            {
                MusicPlayer.URL = listPath[MusicList.SelectedIndex];
                MusicPlayer.Ctlcontrols.play();
                btnPlayOrPause.Text = "暂停";
            }
            catch
            {
            }
        }
    }
}
