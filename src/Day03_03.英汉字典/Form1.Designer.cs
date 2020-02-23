namespace Day03_03.英汉字典
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
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(52, 49);
            this.txtEnglish.Multiline = true;
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(367, 98);
            this.txtEnglish.TabIndex = 0;
            // 
            // txtChinese
            // 
            this.txtChinese.Location = new System.Drawing.Point(52, 199);
            this.txtChinese.Multiline = true;
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(367, 190);
            this.txtChinese.TabIndex = 1;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(477, 158);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 2;
            this.btnTranslate.Text = "翻译";
            this.btnTranslate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.txtEnglish);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.Button btnTranslate;
    }
}

