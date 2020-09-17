namespace Day04_01.节点树控件介绍
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
            this.tv = new System.Windows.Forms.TreeView();
            this.tbRootNode = new System.Windows.Forms.TextBox();
            this.bAddRootNode = new System.Windows.Forms.Button();
            this.bAddChildNode = new System.Windows.Forms.Button();
            this.tbChildNode = new System.Windows.Forms.TextBox();
            this.bRemoveCurNode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tv
            // 
            this.tv.Location = new System.Drawing.Point(51, 57);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(270, 315);
            this.tv.TabIndex = 0;
            // 
            // tbRootNode
            // 
            this.tbRootNode.Location = new System.Drawing.Point(461, 119);
            this.tbRootNode.Name = "tbRootNode";
            this.tbRootNode.Size = new System.Drawing.Size(100, 21);
            this.tbRootNode.TabIndex = 1;
            // 
            // bAddRootNode
            // 
            this.bAddRootNode.Location = new System.Drawing.Point(461, 146);
            this.bAddRootNode.Name = "bAddRootNode";
            this.bAddRootNode.Size = new System.Drawing.Size(75, 23);
            this.bAddRootNode.TabIndex = 2;
            this.bAddRootNode.Text = "添加根节点";
            this.bAddRootNode.UseVisualStyleBackColor = true;
            this.bAddRootNode.Click += new System.EventHandler(this.bAddRootNode_Click);
            // 
            // bAddChildNode
            // 
            this.bAddChildNode.Location = new System.Drawing.Point(461, 208);
            this.bAddChildNode.Name = "bAddChildNode";
            this.bAddChildNode.Size = new System.Drawing.Size(75, 23);
            this.bAddChildNode.TabIndex = 4;
            this.bAddChildNode.Text = "添加根节点";
            this.bAddChildNode.UseVisualStyleBackColor = true;
            this.bAddChildNode.Click += new System.EventHandler(this.bAddChildNode_Click);
            // 
            // tbChildNode
            // 
            this.tbChildNode.Location = new System.Drawing.Point(461, 181);
            this.tbChildNode.Name = "tbChildNode";
            this.tbChildNode.Size = new System.Drawing.Size(100, 21);
            this.tbChildNode.TabIndex = 3;
            // 
            // bRemoveCurNode
            // 
            this.bRemoveCurNode.Location = new System.Drawing.Point(461, 237);
            this.bRemoveCurNode.Name = "bRemoveCurNode";
            this.bRemoveCurNode.Size = new System.Drawing.Size(85, 23);
            this.bRemoveCurNode.TabIndex = 5;
            this.bRemoveCurNode.Text = "删除当前节点";
            this.bRemoveCurNode.UseVisualStyleBackColor = true;
            this.bRemoveCurNode.Click += new System.EventHandler(this.bRemoveCurNode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bRemoveCurNode);
            this.Controls.Add(this.bAddChildNode);
            this.Controls.Add(this.tbChildNode);
            this.Controls.Add(this.bAddRootNode);
            this.Controls.Add(this.tbRootNode);
            this.Controls.Add(this.tv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.TextBox tbRootNode;
        private System.Windows.Forms.Button bAddRootNode;
        private System.Windows.Forms.Button bAddChildNode;
        private System.Windows.Forms.TextBox tbChildNode;
        private System.Windows.Forms.Button bRemoveCurNode;
    }
}

