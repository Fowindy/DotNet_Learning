namespace Day06_02_01.窗体传值_委托和单例综合应用_重要_
{
    partial class FrmSingle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bSingle = new System.Windows.Forms.Button();
            this.tbSingle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bSingle
            // 
            this.bSingle.Location = new System.Drawing.Point(271, 175);
            this.bSingle.Name = "bSingle";
            this.bSingle.Size = new System.Drawing.Size(94, 23);
            this.bSingle.TabIndex = 3;
            this.bSingle.Text = "传值到父窗体";
            this.bSingle.UseVisualStyleBackColor = true;
            // 
            // tbSingle
            // 
            this.tbSingle.Location = new System.Drawing.Point(71, 123);
            this.tbSingle.Name = "tbSingle";
            this.tbSingle.Size = new System.Drawing.Size(294, 21);
            this.tbSingle.TabIndex = 2;
            // 
            // FrmSingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 341);
            this.Controls.Add(this.bSingle);
            this.Controls.Add(this.tbSingle);
            this.Name = "FrmSingle";
            this.Text = "子窗体";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSingle;
        private System.Windows.Forms.TextBox tbSingle;
    }
}