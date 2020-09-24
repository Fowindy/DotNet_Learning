namespace Day04_04_01.爬取天气数据_API_GET方式
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
            this.nudCityCount = new System.Windows.Forms.NumericUpDown();
            this.cbCityName = new System.Windows.Forms.ComboBox();
            this.bQueryWeatherAll = new System.Windows.Forms.Button();
            this.bQueryWeather = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbAPIInterface = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCityCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nudCityCount
            // 
            this.nudCityCount.Location = new System.Drawing.Point(380, 422);
            this.nudCityCount.Name = "nudCityCount";
            this.nudCityCount.Size = new System.Drawing.Size(52, 21);
            this.nudCityCount.TabIndex = 12;
            this.nudCityCount.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // cbCityName
            // 
            this.cbCityName.FormattingEnabled = true;
            this.cbCityName.Location = new System.Drawing.Point(97, 424);
            this.cbCityName.Name = "cbCityName";
            this.cbCityName.Size = new System.Drawing.Size(101, 20);
            this.cbCityName.TabIndex = 11;
            // 
            // bQueryWeatherAll
            // 
            this.bQueryWeatherAll.Location = new System.Drawing.Point(438, 421);
            this.bQueryWeatherAll.Name = "bQueryWeatherAll";
            this.bQueryWeatherAll.Size = new System.Drawing.Size(142, 23);
            this.bQueryWeatherAll.TabIndex = 10;
            this.bQueryWeatherAll.Text = "全国所有地区一键查询";
            this.bQueryWeatherAll.UseVisualStyleBackColor = true;
            this.bQueryWeatherAll.Click += new System.EventHandler(this.bQueryWeatherAll_Click);
            // 
            // bQueryWeather
            // 
            this.bQueryWeather.Location = new System.Drawing.Point(204, 422);
            this.bQueryWeather.Name = "bQueryWeather";
            this.bQueryWeather.Size = new System.Drawing.Size(75, 23);
            this.bQueryWeather.TabIndex = 9;
            this.bQueryWeather.Text = "查询";
            this.bQueryWeather.UseVisualStyleBackColor = true;
            this.bQueryWeather.Click += new System.EventHandler(this.bQueryWeather_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "请输入城市名称";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 411);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // tbAPIInterface
            // 
            this.tbAPIInterface.Location = new System.Drawing.Point(627, 423);
            this.tbAPIInterface.Name = "tbAPIInterface";
            this.tbAPIInterface.ReadOnly = true;
            this.tbAPIInterface.Size = new System.Drawing.Size(451, 21);
            this.tbAPIInterface.TabIndex = 13;
            this.tbAPIInterface.Text = "https://v0.yiketianqi.com/api?version=v9&appid=24985512&appsecret=eQf9O5BH";
            this.tbAPIInterface.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbAPIInterface_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "按序查询城市数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "API接口";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAPIInterface);
            this.Controls.Add(this.nudCityCount);
            this.Controls.Add(this.cbCityName);
            this.Controls.Add(this.bQueryWeatherAll);
            this.Controls.Add(this.bQueryWeather);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "天气查询";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCityCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudCityCount;
        private System.Windows.Forms.ComboBox cbCityName;
        private System.Windows.Forms.Button bQueryWeatherAll;
        private System.Windows.Forms.Button bQueryWeather;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbAPIInterface;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

