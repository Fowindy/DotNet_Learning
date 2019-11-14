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
            this.btnStop.Enabled = false;
            IsPlay = false;
        }
        bool IsPlay = false;
        int PreIndex = 0;
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
                if (MusicList.Items.Count == 0)
                {
                    MessageBox.Show("音乐列表为空,请先加载音乐列表");
                    return;
                }
                else if (MusicList.SelectedIndex == -1)
                {
                    MusicPlayer.URL = listPath[0];
                    MusicList.SelectedIndex = 0;
                    PreIndex = 0;
                    IsPlay = true;
                }
                else if (!IsPlay)
                {
                    MusicPlayer.URL = listPath[MusicList.SelectedIndex];
                    PreIndex = MusicList.SelectedIndex;
                    IsPlay = true;
                }
                MusicPlayer.Ctlcontrols.play();
                btnPlayOrPause.Text = "暂停";
                this.btnStop.Enabled = true;
            }
            else
            {
                if (MusicList.SelectedIndex != PreIndex)
                {
                    MusicPlayer.Ctlcontrols.stop();
                    IsPlay = false;
                    this.btnStop.Enabled = false;
                }
                else
                {
                    MusicPlayer.Ctlcontrols.pause();
                    IsPlay = true;
                    this.btnStop.Enabled = true;
                }
                btnPlayOrPause.Text = "播放";
            }
            btnNext.Enabled = true;
            btnForward.Enabled = true;
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
            MusicList.SelectedIndex = 0;
            btnNext.Enabled = true;
            btnForward.Enabled = true;
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
                MessageBox.Show("音乐列表为空,请先选择音乐文件");
                //结束本次方法,不执行下面的操作
                return;
            }
            //异常处理2:当在列表空白的地方双击时,抛异常;
            //拿到双击对象的URL
            try
            {
                MusicPlayer.URL = listPath[MusicList.SelectedIndex];
                MusicPlayer.Ctlcontrols.play();
                IsPlay = true;
                PreIndex = MusicList.SelectedIndex;
                btnPlayOrPause.Text = "暂停";
                btnNext.Enabled = true;
                btnForward.Enabled = true;
                this.btnStop.Enabled = true;
            }
            catch
            {
            }
        }
        /// <summary>
        /// 上一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnForward_Click(object sender, EventArgs e)
        {
            int index = PreIndex;
            //清空所有选中项的索引
            MusicList.SelectedIndices.Clear();
            index--;
            if (index == -1)
            {
                index = listPath.Count - 1;
            }
            MusicPlayer.URL = listPath[index];
            MusicList.SelectedIndex = index;
            PreIndex = index;
            MusicPlayer.Ctlcontrols.play();
            btnPlayOrPause.Text = "暂停";
            this.btnStop.Enabled = true;
            IsPlay = true;
        }
        /// <summary>
        /// 下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            int index = PreIndex;
            //清空所有选中项的索引
            MusicList.SelectedIndices.Clear();
            index++;
            if (index == listPath.Count)
            {
                index = 0;
            }
            MusicPlayer.URL = listPath[index];
            MusicList.SelectedIndex = index;
            PreIndex = index;
            MusicPlayer.Ctlcontrols.play();
            btnPlayOrPause.Text = "暂停";
            this.btnStop.Enabled = true;
            IsPlay = true;
        }
        /// <summary>
        /// 程序加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //$7.2.在程序加载的时候,取消播放器默认的自动播放功能_没能成功_因为Url赋值即触发播放
            MusicPlayer.settings.autoStart = false;
            //$7.3.在程序加载的时候,取消播放器默认的自动播放功能_成功_先取消自动播放,后对URL赋值
            //MusicPlayer.URL = @"C:\Users\Administrator\Desktop\传智播客C#案例资料\Day21\简单播放器\周杰伦 - 给我一首歌的时间.mp3";
            this.btnStop.Enabled = false;
            //$7.14.在程序加载的时候显示放音icon
            label1.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\传智播客C#案例资料\Day21\简单播放器\放音.png");
        }
        /// <summary>
        /// $7.13.3.多选删除_点击删除选中项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int count = MusicList.Items.Count;
            //for循环删除
            for (int i = 0; i < MusicList.Items.Count; i++)
            {
                if (MusicList.SelectedIndices.Contains(i))
                {
                    if (PreIndex > MusicList.SelectedIndex)
                    {
                        PreIndex--;
                    }
                    else if (PreIndex == MusicList.SelectedIndex && MusicList.SelectedIndex == MusicList.Items.Count-1)
                    {
                        PreIndex--;
                        MusicPlayer.Ctlcontrols.stop();
                        IsPlay = false;
                        btnPlayOrPause.Text = "播放";
                        this.btnStop.Enabled = false;
                    }
                    else if (PreIndex == MusicList.SelectedIndex && MusicList.SelectedIndex == 0)
                    {
                        MusicPlayer.Ctlcontrols.stop();
                        IsPlay = false;
                        btnPlayOrPause.Text = "播放";
                        this.btnStop.Enabled = false;
                    }
                    else if (PreIndex == MusicList.SelectedIndex && 0 < MusicList.SelectedIndex && MusicList.SelectedIndex < MusicList.Items.Count - 1)
                    {
                        MusicPlayer.Ctlcontrols.stop();
                        IsPlay = false;
                        btnPlayOrPause.Text = "播放";
                        this.btnStop.Enabled = false;
                    }
                    //一定先删MusicList之外的listPath列表(listPath存了所有歌曲的全路径),因为是根据MusicList的选中index删除的;如果先删MusicList,index也发生了变化,再删集合的时候容易出错
                    listPath.RemoveAt(i);
                    //if (i == MusicList.Items.Count-1)
                    //{
                    //    MusicList.SelectedIndex = 0;
                    //}
                    //再删MusicList列表
                    MusicList.Items.RemoveAt(i);
                    i--;
                    //清空所有选中项的索引
                    //MusicList.SelectedIndices.Clear();
                }

            }
            if (MusicList.Items.Count != 0 && PreIndex != MusicList.SelectedIndex)
            {
                MusicList.SelectedIndex = PreIndex;
                this.btnStop.Enabled = false;
            }
            if (MusicList.SelectedIndex == -1 || MusicList.Items.Count == 0)
            {
                try
                {
                    if (MusicList.Items.Count != 0)
                    {
                        MusicList.SelectedIndex = PreIndex;
                        MusicPlayer.Ctlcontrols.stop();
                        IsPlay = false;
                        btnPlayOrPause.Text = "播放";
                        this.btnStop.Enabled = true;
                    }
                    else
                    {
                        this.btnStop.Enabled = false;
                    }

                }
                catch
                {
                    this.btnStop.Enabled = false;
                    this.btnForward.Enabled = false;
                    this.btnNext.Enabled = false;
                }
            }
        }

        /// <summary>
        /// 静音or放音点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            //label1的tag属性:可以标注状态;将tag属性默认标记为:1;表示放音;
            //对tag属性进行判断
            //如果现在显示的是放音,那么点击的目的是静音
            if (label1.Tag.ToString() == "1")
            {
                //播放器静音操作
                MusicPlayer.settings.mute = true;
                //将tag属性标记为静音:2
                label1.Tag = "2";
                //并且切换静音图标
                label1.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\传智播客C#案例资料\Day21\简单播放器\静音.png");
            }
            //如果现在显示的是静音,那么点击的目的是放音
            else
            {
                //播放器放音操作
                MusicPlayer.settings.mute = false;
                //将tag属性标记为放音:1
                label1.Tag = "1";
                //并且将图标切换放音图标
                label1.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\传智播客C#案例资料\Day21\简单播放器\放音.png");
            }
        }
    }
}
