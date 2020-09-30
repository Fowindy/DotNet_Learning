namespace Day06_10.委托三连击_事件实现
{
    partial class UserThreeClick_Event
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ThreeClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ThreeClick
            // 
            this.ThreeClick.Location = new System.Drawing.Point(0, 0);
            this.ThreeClick.Name = "ThreeClick";
            this.ThreeClick.Size = new System.Drawing.Size(150, 47);
            this.ThreeClick.TabIndex = 0;
            this.ThreeClick.Text = "三连击_事件";
            this.ThreeClick.UseVisualStyleBackColor = true;
            this.ThreeClick.Click += new System.EventHandler(this.ThreeClick_Click);
            // 
            // UserThreeClick_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ThreeClick);
            this.Name = "UserThreeClick_Event";
            this.Size = new System.Drawing.Size(150, 46);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ThreeClick;
    }
}
