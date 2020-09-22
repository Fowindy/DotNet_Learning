/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年9月18日 星期五 09:57:48
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
using System.Threading;
using System.Net;
using Newtonsoft.Json;
using static Day04_04_01.爬取天气数据_API_GET方式.API_RequestWebData;
using static Fowindy.Day04_04_01.爬取天气数据_API_GET方式.AeraCode.AeraCode;
using System.Reflection;

namespace Day04_04_01.爬取天气数据_API_GET方式
{
    public partial class Form1 : Form
    {
        DataTable dataTable = new DataTable();
        MatchCollection matches;
        List<string> list = new List<string>();
        API_RequestWebData api = new API_RequestWebData();
        public Form1()
        {
            //设置窗体的双缓冲
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            InitializeComponent();

            //利用反射设置DataGridView的双缓冲
            Type dgvType = this.dataGridView1.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(this.dataGridView1, true, null);

            CheckForIllegalCrossThreadCalls = false;
        }
        /// <summary>
        /// 查询目标城市7天天气
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bQueryWeather_Click(object sender, EventArgs e)
        {
            tbAPIInterface.ReadOnly = true;
            string cityName = cbCityName.Text;//获取当前城市
            //判断输入的城市名下拉选项中有没有,没有则提示输入错误
            if (list.Contains(cityName))
            {
                //调用查询天气函数
                QueryWeatherByCity(cityName);
                //列宽自适应
                AutoSizeColumn(dataGridView1);
            }
            else
            {
                MessageBox.Show("输入城市名称不存在,请重新输入或下拉选择!");
            }
        }
        /// <summary>
        /// 初始化表格
        /// </summary>
        private void InitDatable()
        {
            DataColumn col1 = new DataColumn("城市名称", typeof(string));
            DataColumn col2 = new DataColumn("城市代码", typeof(string));
            DataColumn col3 = new DataColumn("日期", typeof(string));
            DataColumn col4 = new DataColumn("星期", typeof(string));
            DataColumn col5 = new DataColumn("天气", typeof(string));
            DataColumn col6 = new DataColumn("最低温度", typeof(string));
            DataColumn col7 = new DataColumn("最高温度", typeof(string));
            DataColumn col8 = new DataColumn("风速", typeof(string));
            DataColumn col9 = new DataColumn("日出", typeof(string));
            DataColumn col10 = new DataColumn("日落", typeof(string));
            DataColumn col11 = new DataColumn("空气质量", typeof(string));
            DataColumn col12 = new DataColumn("更新时间", typeof(string));
            //新建列
            //添加列
            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);
            dataTable.Columns.Add(col8);
            dataTable.Columns.Add(col9);
            dataTable.Columns.Add(col10);
            dataTable.Columns.Add(col11);
            dataTable.Columns.Add(col12);
            //绑定数据
            this.dataGridView1.DataSource = dataTable.DefaultView;
            //列宽自适应
            AutoSizeColumn(dataGridView1);
        }
        /// <summary>
        /// 调用API接口查询单城市天气函数
        /// </summary>
        /// <param name="cityName"></param>
        private void QueryWeatherByCity(string cityName)
        {
            string apiInterface = tbAPIInterface.Text;
            //调用api接口Get方法获取Json天气数据
            string getJson = api.GetJson(apiInterface + "&city=" + cityName);
            Root rt = null;
            try
            {
                //反序列化API反馈的JSON天气数据
                rt = JsonConvert.DeserializeObject<Root>(getJson);
            }
            catch
            {
            }
            for (int i = 0; i < rt.data.Count; i++)
            {
                DataRow dr = dataTable.NewRow();
                dr["城市名称"] = rt.city;
                dr["城市代码"] = rt.cityid;
                dr["日期"] = rt.data[i].date;
                dr["星期"] = rt.data[i].week;
                dr["天气"] = rt.data[i].wea_day;
                dr["最低温度"] = rt.data[i].tem2;
                dr["最高温度"] = rt.data[i].tem1;
                dr["风速"] = rt.data[i].win_speed;
                dr["日出"] = rt.data[i].sunrise;
                dr["日落"] = rt.data[i].sunset;
                dr["空气质量"] = rt.data[i].air_level;
                dr["更新时间"] = rt.update_time;
                dataTable.Rows.Add(dr);
            }
            //单行刷新
            //dataGridView1.Refresh();
        }
        /// <summary>
        /// 按次序查询指定数量城市7天天气
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bQueryWeatherAll_Click(object sender, EventArgs e)
        {
            tbAPIInterface.ReadOnly = true;
            Thread thread = new Thread(QueryWeatherByCities);
            thread.IsBackground = true;
            thread.Start();
            #region 第二种多线程的方式
            //new Thread(() =>
            //{             //遍历批量查询
            //    for (int i = 0; i < nudCityCount.Value; i++)
            //    {
            //        QueryWeatherByCity(list[i]);
            //    }
            //}).Start(); 
            #endregion
        }

        private void QueryWeatherByCities()
        {
            //遍历批量查询
            for (int i = 0; i < nudCityCount.Value; i++)
            {
                QueryWeatherByCity(list[i]);
            }
            //列宽自适应
            AutoSizeColumn(dataGridView1);
        }

        /// <summary>
        /// 查询城市名称代号(正则表达式爬虫实现)
        /// </summary>
        /// <returns></returns>
        private static MatchCollection QueryCityNameCode()
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;//编码格式转为UTF8防止乱码
            //爬取目标网页信息
            string html = null;
            MatchCollection matches = null;
            try
            {
                html = webClient.DownloadString("http://www.360doc.com/content/09/0521/10/148909_3588503.shtml");
                //正则表达式解析全国各地区名称及代码
                matches = Regex.Matches(html, @"[\u4e00-\u9fa5]+[ ][0-9]{5}");
            }
            catch
            {
            }
            return matches;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitDatable();
            #region 远程爬取地区名称
            matches = QueryCityNameCode();
            if (matches != null)
            {
                foreach (Match item in matches)
                {
                    list.Add(item.Value.Split(' ')[0]);
                }
            } 
            #endregion
            #region 解析本地地区Json获取地区名称
            string getJson = File.ReadAllText(@"..\..\相关资料\全国地区编号.json", Encoding.Default);
            RootArea rt = JsonConvert.DeserializeObject<RootArea>(getJson);
            string name = (rt.zone)[0].zone[1].name;
            for (int i = 0; i < rt.zone.Count; i++)
            {
                for (int j = 0; j < rt.zone[i].zone.Count; j++)
                {
                    if (!list.Contains(rt.zone[i].zone[j].name))
                    {
                        list.Add(rt.zone[i].zone[j].name);
                    }
                    for (int k = 0; k < rt.zone[i].zone[j].zone.Count; k++)
                    {
                        if (!list.Contains(rt.zone[i].zone[j].zone[k].name))
                        {
                            list.Add(rt.zone[i].zone[j].zone[k].name);
                        }
                    }
                }
            } 
            #endregion
            //城市数量的最大值不能超过地区列表最大值
            nudCityCount.Maximum = list.Count;
            //默认城市名称为第一个
            cbCityName.DataSource = list;
        }
        /// <summary>
        /// 使DataGridView的列自适应宽度
        /// </summary>
        /// <param name="dgViewFiles"></param>
        private void AutoSizeColumn(DataGridView dgViewFiles)
        {
            int width = 0;
            //使列自使用宽度
            //对于DataGridView的每一个列都调整
            for (int i = 0; i < dgViewFiles.Columns.Count; i++)
            {
                //将每一列都调整为自动适应模式
                dgViewFiles.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);
                //记录整个DataGridView的宽度
                width += dgViewFiles.Columns[i].Width;
            }
            //判断调整后的宽度与原来设定的宽度的关系，如果是调整后的宽度大于原来设定的宽度，
            //则将DataGridView的列自动调整模式设置为显示的列即可，
            //如果是小于原来设定的宽度，将模式改为填充。
            if (width > dgViewFiles.Size.Width)
            {
                dgViewFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else
            {
                dgViewFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            //冻结某列 从左开始 0，1
            dgViewFiles.Columns[1].Frozen = true;
        }
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
            //序号栏自适应显示:将RowHeadersWidthSizeMode设置AutoSizeToAllHeaders
        }

        private void tbAPIInterface_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbAPIInterface.ReadOnly = false;
        }
    }
}
