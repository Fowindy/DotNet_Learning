﻿namespace Day06_02_01.窗体传值_委托和单例综合应用_重要_
{
    partial class FrmMain
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
            this.tbMain = new System.Windows.Forms.TextBox();
            this.bMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMain
            // 
            this.tbMain.Location = new System.Drawing.Point(65, 95);
            this.tbMain.Name = "tbMain";
            this.tbMain.Size = new System.Drawing.Size(294, 21);
            this.tbMain.TabIndex = 0;
            // 
            // bMain
            // 
            this.bMain.Location = new System.Drawing.Point(265, 147);
            this.bMain.Name = "bMain";
            this.bMain.Size = new System.Drawing.Size(94, 23);
            this.bMain.TabIndex = 1;
            this.bMain.Text = "传值到子窗体";
            this.bMain.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 341);
            this.Controls.Add(this.bMain);
            this.Controls.Add(this.tbMain);
            this.Name = "FrmMain";
            this.Text = "父窗体";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMain;
        private System.Windows.Forms.Button bMain;
    }
}

