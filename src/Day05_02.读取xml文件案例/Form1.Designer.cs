namespace Day05_02.读取xml文件案例
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
            this.treeView = new System.Windows.Forms.TreeView();
            this.tbXmlPath = new System.Windows.Forms.TextBox();
            this.bLoadXmlToTree = new System.Windows.Forms.Button();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(52, 35);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(334, 386);
            this.treeView.TabIndex = 0;
            // 
            // tbXmlPath
            // 
            this.tbXmlPath.Location = new System.Drawing.Point(392, 35);
            this.tbXmlPath.Name = "tbXmlPath";
            this.tbXmlPath.Size = new System.Drawing.Size(396, 21);
            this.tbXmlPath.TabIndex = 2;
            this.tbXmlPath.Text = "..\\..\\相关资料\\首页菜单.xml";
            // 
            // bLoadXmlToTree
            // 
            this.bLoadXmlToTree.Location = new System.Drawing.Point(392, 62);
            this.bLoadXmlToTree.Name = "bLoadXmlToTree";
            this.bLoadXmlToTree.Size = new System.Drawing.Size(105, 23);
            this.bLoadXmlToTree.TabIndex = 3;
            this.bLoadXmlToTree.Text = "导入xml并生成树";
            this.bLoadXmlToTree.UseVisualStyleBackColor = true;
            this.bLoadXmlToTree.Click += new System.EventHandler(this.bLoadXmlToTree_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bLoadXmlToTree);
            this.Controls.Add(this.tbXmlPath);
            this.Controls.Add(this.treeView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.TextBox tbXmlPath;
        private System.Windows.Forms.Button bLoadXmlToTree;
        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
    }
}

