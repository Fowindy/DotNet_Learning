namespace Day04_02.资料管理器
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.bPathLoad = new System.Windows.Forms.Button();
            this.tbPathLoad = new System.Windows.Forms.TextBox();
            this.tv = new System.Windows.Forms.TreeView();
            this.tbShowDetail = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbShowDetail);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.bPathLoad);
            this.splitContainer2.Panel1.Controls.Add(this.tbPathLoad);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tv);
            this.splitContainer2.Size = new System.Drawing.Size(266, 450);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 0;
            // 
            // bPathLoad
            // 
            this.bPathLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bPathLoad.Location = new System.Drawing.Point(204, 0);
            this.bPathLoad.Name = "bPathLoad";
            this.bPathLoad.Size = new System.Drawing.Size(62, 25);
            this.bPathLoad.TabIndex = 1;
            this.bPathLoad.Text = "...";
            this.bPathLoad.UseVisualStyleBackColor = true;
            this.bPathLoad.Click += new System.EventHandler(this.bPathLoad_Click);
            // 
            // tbPathLoad
            // 
            this.tbPathLoad.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbPathLoad.Location = new System.Drawing.Point(0, 0);
            this.tbPathLoad.Multiline = true;
            this.tbPathLoad.Name = "tbPathLoad";
            this.tbPathLoad.Size = new System.Drawing.Size(204, 25);
            this.tbPathLoad.TabIndex = 0;
            // 
            // tv
            // 
            this.tv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv.Location = new System.Drawing.Point(0, 0);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(266, 421);
            this.tv.TabIndex = 0;
            this.tv.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_NodeMouseDoubleClick);
            // 
            // tbShowDetail
            // 
            this.tbShowDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbShowDetail.Location = new System.Drawing.Point(0, 0);
            this.tbShowDetail.Multiline = true;
            this.tbShowDetail.Name = "tbShowDetail";
            this.tbShowDetail.Size = new System.Drawing.Size(530, 450);
            this.tbShowDetail.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.TextBox tbShowDetail;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox tbPathLoad;
        private System.Windows.Forms.Button bPathLoad;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

