/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年9月17日 星期四 19:21:03
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;
using System.Threading;

namespace Day04_04.爬取天气数据
{
    public partial class Form1 : Form
    {
        DataTable dataTable = new DataTable();
        MatchCollection matches;
        List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private delegate void UpdateDataGridView(DataTable dt);
        private void UpdateGV(DataTable dt)
        {
            if (dataGridView1.InvokeRequired)
            {
                this.BeginInvoke(new UpdateDataGridView(UpdateGV), new object[] { dt });
            }
            else
            {
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }
        public void ShowDT()
        {
            UpdateGV(dataTable);
        }
        Weather.WeatherWebService weather = new Weather.WeatherWebService();
        private void bQueryWeather_Click(object sender, EventArgs e)
        {
            string cityName = cbCityName.Text;//获取当前城市
            if (list.Contains(cityName))
            {
                QueryWeatherByCity(cityName);
            }
            else
            {
                MessageBox.Show("输入城市名称不存在,请重新输入或下拉选择!");
            }
        }
        private void InitDatable()
        {
            //新建列
            DataColumn col1 = new DataColumn("城市名称", typeof(string));
            DataColumn col2 = new DataColumn("城市代码", typeof(string));
            DataColumn col3 = new DataColumn("日期", typeof(string));
            DataColumn col4 = new DataColumn("天气", typeof(string));
            DataColumn col5 = new DataColumn("最低温度", typeof(string));
            DataColumn col6 = new DataColumn("最高温度", typeof(string));
            DataColumn col7 = new DataColumn("风力", typeof(string));
            DataColumn col8 = new DataColumn("更新时间", typeof(string));
            //添加列
            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);
            dataTable.Columns.Add(col8);
            //绑定数据
            this.dataGridView1.DataSource = dataTable.DefaultView;
        }
        private void QueryWeatherByCity(string cityName)
        {
            //UpdateDataGridView updateDataGridView;
            //updateDataGridView = UpdateGV;
            //UpdateGV(dataTable);
            string[] weatherInfo = new string[23];//准备一个数组存放结果
            weatherInfo = weather.getWeatherbyCityName(cityName);
            int i = 0;
            DataRow dataRow;
            do
            {
                dataRow = dataTable.NewRow();
                //int index = dataGridView1.Rows.Add(row);
                dataRow["城市名称"] = weatherInfo[1];
                dataRow["城市代码"] = weatherInfo[2];
                dataRow["日期"] = weatherInfo[6 + i].Split(' ')[0];
                dataRow["天气"] = weatherInfo[6 + i].Split(' ')[1];
                dataRow["最低温度"] = weatherInfo[5 + i].Split('/')[0];
                dataRow["最高温度"] = weatherInfo[5 + i].Split('/')[1];
                dataRow["风力"] = weatherInfo[7 + i];
                dataRow["更新时间"] = weatherInfo[4];
                i = i == 0 ? i + 7 : i + 5;
                dataTable.Rows.Add(dataRow);
                this.dataGridView1.DataSource = dataTable.DefaultView;
                //Task.Factory.StartNew(() => ShowDT());
            } while (i == 7 || i == 12);

            //do
            //{
            //    DataGridViewRow row = new DataGridViewRow();
            //    int index = dataGridView1.Rows.Add(row);
            //    dataGridView1.Rows[index].Cells[0].Value = weatherInfo[1];
            //    dataGridView1.Rows[index].Cells[1].Value = weatherInfo[2];
            //    dataGridView1.Rows[index].Cells[2].Value = weatherInfo[6 + i].Split(' ')[0];
            //    dataGridView1.Rows[index].Cells[3].Value = weatherInfo[6 + i].Split(' ')[1];
            //    dataGridView1.Rows[index].Cells[4].Value = weatherInfo[5 + i].Split('/')[0];
            //    dataGridView1.Rows[index].Cells[5].Value = weatherInfo[5 + i].Split('/')[1];
            //    dataGridView1.Rows[index].Cells[6].Value = weatherInfo[7 + i];
            //    dataGridView1.Rows[index].Cells[7].Value = weatherInfo[4];
            //    i = i == 0 ? i + 7 : i + 5;
            //} while (i == 7 || i == 12);
        }

        private void bQueryWeatherAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nudCityCount.Value; i++)
            {
                QueryWeatherByCity(matches[i].Value.Split(' ')[0]);
                Thread.Sleep(1000);
            }
        }

        private static MatchCollection QueryCityNameCode()
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;//编码格式转为UTF8防止乱码
            //爬取目标网页信息
            string html = webClient.DownloadString("http://www.360doc.com/content/09/0521/10/148909_3588503.shtml");
            //正则表达式解析全国各地区名称及代码
            MatchCollection matches = Regex.Matches(html, @"[\u4e00-\u9fa5]+[ ][0-9]{5}");
            return matches;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitDatable();
            matches = QueryCityNameCode();
            foreach (Match item in matches)
            {
                list.Add(item.Value.Split(' ')[0]);
            }
            cbCityName.DataSource = list;
            nudCityCount.Maximum = matches.Count;
            //Task.Factory.StartNew(() => ShowDT());
        }
    }
}
