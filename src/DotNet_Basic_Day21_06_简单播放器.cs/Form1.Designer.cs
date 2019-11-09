namespace DotNet_Basic_Day21_06_简单播放器.cs
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPlayOrPause = new System.Windows.Forms.Button();
            this.MusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnLoadMusic = new System.Windows.Forms.Button();
            this.MusicList = new System.Windows.Forms.ListBox();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "播放";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "暂停";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "停止";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(530, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 145);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "老版播放器";
            // 
            // btnPlayOrPause
            // 
            this.btnPlayOrPause.Location = new System.Drawing.Point(22, 335);
            this.btnPlayOrPause.Name = "btnPlayOrPause";
            this.btnPlayOrPause.Size = new System.Drawing.Size(75, 23);
            this.btnPlayOrPause.TabIndex = 5;
            this.btnPlayOrPause.Text = "播放";
            this.btnPlayOrPause.UseVisualStyleBackColor = true;
            this.btnPlayOrPause.Click += new System.EventHandler(this.btnPlayOrPause_Click);
            // 
            // MusicPlayer
            // 
            this.MusicPlayer.Enabled = true;
            this.MusicPlayer.Location = new System.Drawing.Point(12, 12);
            this.MusicPlayer.Name = "MusicPlayer";
            this.MusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MusicPlayer.OcxState")));
            this.MusicPlayer.Size = new System.Drawing.Size(512, 316);
            this.MusicPlayer.TabIndex = 0;
            this.MusicPlayer.Enter += new System.EventHandler(this.MusicPlayer_Enter);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(103, 335);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLoadMusic
            // 
            this.btnLoadMusic.Location = new System.Drawing.Point(536, 175);
            this.btnLoadMusic.Name = "btnLoadMusic";
            this.btnLoadMusic.Size = new System.Drawing.Size(75, 23);
            this.btnLoadMusic.TabIndex = 7;
            this.btnLoadMusic.Text = "加载音乐";
            this.btnLoadMusic.UseVisualStyleBackColor = true;
            this.btnLoadMusic.Click += new System.EventHandler(this.btnLoadMusic_Click);
            // 
            // MusicList
            // 
            this.MusicList.FormattingEnabled = true;
            this.MusicList.ItemHeight = 12;
            this.MusicList.Location = new System.Drawing.Point(536, 204);
            this.MusicList.Name = "MusicList";
            this.MusicList.Size = new System.Drawing.Size(252, 232);
            this.MusicList.TabIndex = 8;
            this.MusicList.DoubleClick += new System.EventHandler(this.MusicList_DoubleClick);
            // 
            // btnForward
            // 
            this.btnForward.Enabled = false;
            this.btnForward.Location = new System.Drawing.Point(185, 334);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 23);
            this.btnForward.TabIndex = 9;
            this.btnForward.Text = "上一曲";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(266, 334);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "下一曲";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.MusicList);
            this.Controls.Add(this.btnLoadMusic);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlayOrPause);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MusicPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer MusicPlayer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPlayOrPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnLoadMusic;
        private System.Windows.Forms.ListBox MusicList;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnNext;
    }
}

