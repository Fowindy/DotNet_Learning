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
            this.bXmlToTree = new System.Windows.Forms.Button();
            this.tbXmlPath = new System.Windows.Forms.TextBox();
            this.bLoadXml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(52, 35);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(334, 386);
            this.treeView.TabIndex = 0;
            // 
            // bXmlToTree
            // 
            this.bXmlToTree.Location = new System.Drawing.Point(392, 62);
            this.bXmlToTree.Name = "bXmlToTree";
            this.bXmlToTree.Size = new System.Drawing.Size(100, 23);
            this.bXmlToTree.TabIndex = 1;
            this.bXmlToTree.Text = "读取xml生成树";
            this.bXmlToTree.UseVisualStyleBackColor = true;
            this.bXmlToTree.Click += new System.EventHandler(this.bXmlToTree_Click);
            // 
            // tbXmlPath
            // 
            this.tbXmlPath.Location = new System.Drawing.Point(392, 35);
            this.tbXmlPath.Name = "tbXmlPath";
            this.tbXmlPath.Size = new System.Drawing.Size(326, 21);
            this.tbXmlPath.TabIndex = 2;
            // 
            // bLoadXml
            // 
            this.bLoadXml.Location = new System.Drawing.Point(724, 35);
            this.bLoadXml.Name = "bLoadXml";
            this.bLoadXml.Size = new System.Drawing.Size(64, 23);
            this.bLoadXml.TabIndex = 3;
            this.bLoadXml.Text = "导入xml";
            this.bLoadXml.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bLoadXml);
            this.Controls.Add(this.tbXmlPath);
            this.Controls.Add(this.bXmlToTree);
            this.Controls.Add(this.treeView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button bXmlToTree;
        private System.Windows.Forms.TextBox tbXmlPath;
        private System.Windows.Forms.Button bLoadXml;
    }
}

