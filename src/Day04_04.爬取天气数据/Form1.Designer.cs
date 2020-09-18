namespace Day04_04.爬取天气数据
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bQueryWeather = new System.Windows.Forms.Button();
            this.bQueryWeatherAll = new System.Windows.Forms.Button();
            this.cbCityName = new System.Windows.Forms.ComboBox();
            this.nudCityCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCityCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(800, 411);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入城市名称";
            // 
            // bQueryWeather
            // 
            this.bQueryWeather.Location = new System.Drawing.Point(459, 423);
            this.bQueryWeather.Name = "bQueryWeather";
            this.bQueryWeather.Size = new System.Drawing.Size(75, 23);
            this.bQueryWeather.TabIndex = 3;
            this.bQueryWeather.Text = "查询";
            this.bQueryWeather.UseVisualStyleBackColor = true;
            this.bQueryWeather.Click += new System.EventHandler(this.bQueryWeather_Click);
            // 
            // bQueryWeatherAll
            // 
            this.bQueryWeatherAll.Location = new System.Drawing.Point(540, 423);
            this.bQueryWeatherAll.Name = "bQueryWeatherAll";
            this.bQueryWeatherAll.Size = new System.Drawing.Size(142, 23);
            this.bQueryWeatherAll.TabIndex = 4;
            this.bQueryWeatherAll.Text = "全国所有地区一键查询";
            this.bQueryWeatherAll.UseVisualStyleBackColor = true;
            this.bQueryWeatherAll.Click += new System.EventHandler(this.bQueryWeatherAll_Click);
            // 
            // cbCityName
            // 
            this.cbCityName.FormattingEnabled = true;
            this.cbCityName.Location = new System.Drawing.Point(352, 425);
            this.cbCityName.Name = "cbCityName";
            this.cbCityName.Size = new System.Drawing.Size(101, 20);
            this.cbCityName.TabIndex = 5;
            // 
            // nudCityCount
            // 
            this.nudCityCount.Location = new System.Drawing.Point(689, 423);
            this.nudCityCount.Name = "nudCityCount";
            this.nudCityCount.Size = new System.Drawing.Size(52, 21);
            this.nudCityCount.TabIndex = 6;
            this.nudCityCount.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudCityCount);
            this.Controls.Add(this.cbCityName);
            this.Controls.Add(this.bQueryWeatherAll);
            this.Controls.Add(this.bQueryWeather);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "天气查询(三天)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCityCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bQueryWeather;
        private System.Windows.Forms.Button bQueryWeatherAll;
        private System.Windows.Forms.ComboBox cbCityName;
        private System.Windows.Forms.NumericUpDown nudCityCount;
    }
}

