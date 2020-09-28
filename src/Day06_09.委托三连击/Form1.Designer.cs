namespace Day06_09.委托三连击
{
    partial class Form1
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
            this.utc = new Day06_09.委托三连击.UserThreeClick();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // utc
            // 
            this.utc.Location = new System.Drawing.Point(365, 171);
            this.utc.Name = "utc";
            this.utc.Size = new System.Drawing.Size(150, 68);
            this.utc.TabIndex = 0;
            this.utc.Load += new System.EventHandler(this.userThreeClick1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.utc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserThreeClick utc;
        private System.Windows.Forms.Button button1;
    }
}