﻿namespace DotNet_Basic_Day21_06_简单播放器.cs
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
            this.components = new System.ComponentModel.Container();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblInformation = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLrc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
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
            this.MusicList.ContextMenuStrip = this.contextMenuStrip1;
            this.MusicList.FormattingEnabled = true;
            this.MusicList.ItemHeight = 12;
            this.MusicList.Location = new System.Drawing.Point(536, 204);
            this.MusicList.Name = "MusicList";
            this.MusicList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.MusicList.Size = new System.Drawing.Size(252, 232);
            this.MusicList.TabIndex = 8;
            this.MusicList.DoubleClick += new System.EventHandler(this.MusicList_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
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
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(347, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 11;
            this.label1.Tag = "1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar1.Location = new System.Drawing.Point(408, 335);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(78, 45);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.TickFrequency = 100;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblInformation
            // 
            this.lblInformation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInformation.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInformation.Location = new System.Drawing.Point(13, 27);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(68, 30);
            this.lblInformation.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.Enabled = false;
            this.label2.Image = global::DotNet_Basic_Day21_06_简单播放器.cs.Properties.Resources.循环播放;
            this.label2.Location = new System.Drawing.Point(490, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 23);
            this.label2.TabIndex = 14;
            this.label2.Tag = "1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 15;
            // 
            // lblLrc
            // 
            this.lblLrc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLrc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblLrc.Location = new System.Drawing.Point(183, 254);
            this.lblLrc.Name = "lblLrc";
            this.lblLrc.Size = new System.Drawing.Size(287, 23);
            this.lblLrc.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLrc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
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
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLrc;
    }
}

