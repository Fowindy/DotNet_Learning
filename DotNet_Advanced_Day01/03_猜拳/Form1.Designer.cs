namespace _03_猜拳
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
            this.labPlayer = new System.Windows.Forms.Label();
            this.labComputer = new System.Windows.Forms.Label();
            this.labPlayerResult = new System.Windows.Forms.Label();
            this.labComputerResult = new System.Windows.Forms.Label();
            this.labVS = new System.Windows.Forms.Label();
            this.labWinResult = new System.Windows.Forms.Label();
            this.btnStone = new System.Windows.Forms.Button();
            this.btnScissor = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labPlayer
            // 
            this.labPlayer.AutoSize = true;
            this.labPlayer.Location = new System.Drawing.Point(90, 62);
            this.labPlayer.Name = "labPlayer";
            this.labPlayer.Size = new System.Drawing.Size(29, 12);
            this.labPlayer.TabIndex = 0;
            this.labPlayer.Text = "玩家";
            // 
            // labComputer
            // 
            this.labComputer.AutoSize = true;
            this.labComputer.Location = new System.Drawing.Point(353, 62);
            this.labComputer.Name = "labComputer";
            this.labComputer.Size = new System.Drawing.Size(29, 12);
            this.labComputer.TabIndex = 1;
            this.labComputer.Text = "电脑";
            // 
            // labPlayerResult
            // 
            this.labPlayerResult.AutoSize = true;
            this.labPlayerResult.Location = new System.Drawing.Point(141, 62);
            this.labPlayerResult.Name = "labPlayerResult";
            this.labPlayerResult.Size = new System.Drawing.Size(53, 12);
            this.labPlayerResult.TabIndex = 2;
            this.labPlayerResult.Text = "出拳结果";
            // 
            // labComputerResult
            // 
            this.labComputerResult.AutoSize = true;
            this.labComputerResult.Location = new System.Drawing.Point(403, 62);
            this.labComputerResult.Name = "labComputerResult";
            this.labComputerResult.Size = new System.Drawing.Size(53, 12);
            this.labComputerResult.TabIndex = 3;
            this.labComputerResult.Text = "出拳结果";
            // 
            // labVS
            // 
            this.labVS.AutoSize = true;
            this.labVS.Location = new System.Drawing.Point(264, 62);
            this.labVS.Name = "labVS";
            this.labVS.Size = new System.Drawing.Size(17, 12);
            this.labVS.TabIndex = 4;
            this.labVS.Text = "VS";
            // 
            // labWinResult
            // 
            this.labWinResult.AutoSize = true;
            this.labWinResult.Location = new System.Drawing.Point(253, 196);
            this.labWinResult.Name = "labWinResult";
            this.labWinResult.Size = new System.Drawing.Size(53, 12);
            this.labWinResult.TabIndex = 5;
            this.labWinResult.Text = "赢还是输";
            // 
            // btnStone
            // 
            this.btnStone.Location = new System.Drawing.Point(132, 328);
            this.btnStone.Name = "btnStone";
            this.btnStone.Size = new System.Drawing.Size(75, 23);
            this.btnStone.TabIndex = 6;
            this.btnStone.Text = "石头";
            this.btnStone.UseVisualStyleBackColor = true;
            this.btnStone.Click += new System.EventHandler(this.btnStone_Click);
            // 
            // btnScissor
            // 
            this.btnScissor.Location = new System.Drawing.Point(255, 328);
            this.btnScissor.Name = "btnScissor";
            this.btnScissor.Size = new System.Drawing.Size(75, 23);
            this.btnScissor.TabIndex = 7;
            this.btnScissor.Text = "剪刀";
            this.btnScissor.UseVisualStyleBackColor = true;
            this.btnScissor.Click += new System.EventHandler(this.btnStone_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(381, 328);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(75, 23);
            this.btnPaper.TabIndex = 8;
            this.btnPaper.Text = "布";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnStone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 493);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnScissor);
            this.Controls.Add(this.btnStone);
            this.Controls.Add(this.labWinResult);
            this.Controls.Add(this.labVS);
            this.Controls.Add(this.labComputerResult);
            this.Controls.Add(this.labPlayerResult);
            this.Controls.Add(this.labComputer);
            this.Controls.Add(this.labPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labPlayer;
        private System.Windows.Forms.Label labComputer;
        private System.Windows.Forms.Label labPlayerResult;
        private System.Windows.Forms.Label labComputerResult;
        private System.Windows.Forms.Label labVS;
        private System.Windows.Forms.Label labWinResult;
        private System.Windows.Forms.Button btnStone;
        private System.Windows.Forms.Button btnScissor;
        private System.Windows.Forms.Button btnPaper;
    }
}

