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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("C盘");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("D盘");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("我的电脑", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("控制面板");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("本地网络");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("无线网络");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("网上邻居", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(51, 57);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点4";
            treeNode1.Text = "C盘";
            treeNode2.Name = "节点5";
            treeNode2.Text = "D盘";
            treeNode3.Name = "节点0";
            treeNode3.Text = "我的电脑";
            treeNode4.Name = "节点1";
            treeNode4.Text = "控制面板";
            treeNode5.Name = "节点6";
            treeNode5.Text = "本地网络";
            treeNode6.Name = "节点7";
            treeNode6.Text = "无线网络";
            treeNode7.Name = "节点2";
            treeNode7.Text = "网上邻居";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(270, 315);
            this.treeView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}

