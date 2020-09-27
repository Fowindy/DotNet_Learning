namespace Day06_02.委托_窗体之间传值
{
    partial class Form2
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
            this.tb2 = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(59, 51);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(237, 21);
            this.tb2.TabIndex = 0;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(177, 162);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(119, 23);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "传值去第一个窗体";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 251);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.tb2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Button btn2;
    }
}