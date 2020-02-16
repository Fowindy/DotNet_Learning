namespace Day01_03.猜拳
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
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissor = new System.Windows.Forms.Button();
            this.btnStone = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.labVS = new System.Windows.Forms.Label();
            this.lblComputerResult = new System.Windows.Forms.Label();
            this.lblPlayerResult = new System.Windows.Forms.Label();
            this.labComputer = new System.Windows.Forms.Label();
            this.labPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(361, 298);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(75, 23);
            this.btnPaper.TabIndex = 17;
            this.btnPaper.Text = "布";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnStone_Click);
            // 
            // btnScissor
            // 
            this.btnScissor.Location = new System.Drawing.Point(235, 298);
            this.btnScissor.Name = "btnScissor";
            this.btnScissor.Size = new System.Drawing.Size(75, 23);
            this.btnScissor.TabIndex = 16;
            this.btnScissor.Text = "剪刀";
            this.btnScissor.UseVisualStyleBackColor = true;
            this.btnScissor.Click += new System.EventHandler(this.btnStone_Click);
            // 
            // btnStone
            // 
            this.btnStone.Location = new System.Drawing.Point(112, 298);
            this.btnStone.Name = "btnStone";
            this.btnStone.Size = new System.Drawing.Size(75, 23);
            this.btnStone.TabIndex = 15;
            this.btnStone.Text = "石头";
            this.btnStone.UseVisualStyleBackColor = true;
            this.btnStone.Click += new System.EventHandler(this.btnStone_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(233, 166);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(53, 12);
            this.lblResult.TabIndex = 14;
            this.lblResult.Text = "赢还是输";
            // 
            // labVS
            // 
            this.labVS.AutoSize = true;
            this.labVS.Location = new System.Drawing.Point(244, 32);
            this.labVS.Name = "labVS";
            this.labVS.Size = new System.Drawing.Size(17, 12);
            this.labVS.TabIndex = 13;
            this.labVS.Text = "VS";
            // 
            // lblComputerResult
            // 
            this.lblComputerResult.AutoSize = true;
            this.lblComputerResult.Location = new System.Drawing.Point(383, 32);
            this.lblComputerResult.Name = "lblComputerResult";
            this.lblComputerResult.Size = new System.Drawing.Size(53, 12);
            this.lblComputerResult.TabIndex = 12;
            this.lblComputerResult.Text = "出拳结果";
            // 
            // lblPlayerResult
            // 
            this.lblPlayerResult.AutoSize = true;
            this.lblPlayerResult.Location = new System.Drawing.Point(121, 32);
            this.lblPlayerResult.Name = "lblPlayerResult";
            this.lblPlayerResult.Size = new System.Drawing.Size(53, 12);
            this.lblPlayerResult.TabIndex = 11;
            this.lblPlayerResult.Text = "出拳结果";
            // 
            // labComputer
            // 
            this.labComputer.AutoSize = true;
            this.labComputer.Location = new System.Drawing.Point(333, 32);
            this.labComputer.Name = "labComputer";
            this.labComputer.Size = new System.Drawing.Size(29, 12);
            this.labComputer.TabIndex = 10;
            this.labComputer.Text = "电脑";
            // 
            // labPlayer
            // 
            this.labPlayer.AutoSize = true;
            this.labPlayer.Location = new System.Drawing.Point(70, 32);
            this.labPlayer.Name = "labPlayer";
            this.labPlayer.Size = new System.Drawing.Size(29, 12);
            this.labPlayer.TabIndex = 9;
            this.labPlayer.Text = "玩家";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 351);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnScissor);
            this.Controls.Add(this.btnStone);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.labVS);
            this.Controls.Add(this.lblComputerResult);
            this.Controls.Add(this.lblPlayerResult);
            this.Controls.Add(this.labComputer);
            this.Controls.Add(this.labPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissor;
        private System.Windows.Forms.Button btnStone;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label labVS;
        private System.Windows.Forms.Label lblComputerResult;
        private System.Windows.Forms.Label lblPlayerResult;
        private System.Windows.Forms.Label labComputer;
        private System.Windows.Forms.Label labPlayer;
    }
}

