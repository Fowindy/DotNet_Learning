namespace MultiThreadTest
{
    partial class MultiThreadTest
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
            this.textLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textLog
            // 
            this.textLog.Location = new System.Drawing.Point(81, 41);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.Size = new System.Drawing.Size(368, 346);
            this.textLog.TabIndex = 0;
            // 
            // MultiThreadTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 528);
            this.Controls.Add(this.textLog);
            this.Name = "MultiThreadTest";
            this.Text = "MultiThreadTest";
            this.Load += new System.EventHandler(this.MultiThreadTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLog;
    }
}

