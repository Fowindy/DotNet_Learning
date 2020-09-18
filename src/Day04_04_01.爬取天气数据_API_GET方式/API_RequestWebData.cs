/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年9月18日 星期五 10:04:45
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Net;

namespace Day04_04_01.爬取天气数据_API_GET方式
{
    public class API_RequestWebData
    {
        /// <summary>
        /// 提交数据请求 post
        /// </summary>
        /// <param name="POSTURL">请求提交的地址 如：http://xxx.xxx.xxx/interface/TestPostRequest</param>
        /// <param name="PostData">提交的数据(字符串)</param>
        /// <returns></returns>
        public static string RequestData(string POSTURL, string PostData)
        {
            //发送请求的数据
            WebRequest myHttpWebRequest = WebRequest.Create(POSTURL);
            myHttpWebRequest.Method = "POST";
            UTF8Encoding encoding = new UTF8Encoding();
            byte[] byte1 = encoding.GetBytes(PostData);
            myHttpWebRequest.ContentType = "application/x-www-form-urlencoded";
            myHttpWebRequest.ContentLength = byte1.Length;
            Stream newStream = myHttpWebRequest.GetRequestStream();
            newStream.Write(byte1, 0, byte1.Length);
            newStream.Close();


            //发送成功后接收返回的XML信息
            HttpWebResponse response = (HttpWebResponse)myHttpWebRequest.GetResponse();
            string lcHtml = string.Empty;
            Encoding enc = Encoding.GetEncoding("UTF-8");
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream, enc);
            lcHtml = streamReader.ReadToEnd();
            return lcHtml;
        }


        /// <summary>  
        /// GET请求与获取结果  
        /// </summary>  
        public static string HttpGet(string Url, string postDataStr)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url + (postDataStr == "" ? "" : "?") + postDataStr);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return retString;
        }

        //WebClient请求方式
        /// <summary>
        /// Get请求方式  
        /// </summary>
        /// <param name="url">get请求url</param>
        /// <returns></returns>
        public string GetJson(string url)
        {
            WebClient wc = new WebClient();
            wc.Credentials = CredentialCache.DefaultCredentials;
            wc.Encoding = Encoding.UTF8;
            string returnText = wc.DownloadString(url);
            if (returnText.Contains("errcode"))
            {
                //可能发生错误  
            }
            return returnText;
        }

        ////get 请求
        //string url = string.Format("http://localhost:28450/api/values?str1=a&str2=b");
        //WebClient wc = new WebClient();
        //Encoding enc = Encoding.GetEncoding("UTF-8");
        //Byte[] pageData = wc.DownloadData(url);
        //string re = enc.GetString(pageData);

        ////post 请求
        //string postData = "value=a";
        //byte[] bytes = Encoding.UTF8.GetBytes(postData);
        //WebClient client = new WebClient();
        //client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
        //client.Headers.Add("ContentLength", postData.Length.ToString());
        //Encoding enc = Encoding.GetEncoding("UTF-8");
        //byte[] responseData = client.UploadData("http://localhost:28450/api/values", "POST", bytes);
        //string re = enc.GetString(responseData);

        public class Alarm
        {
            /// <summary>
            /// 
            /// </summary>
            public string alarm_type { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string alarm_level { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string alarm_content { get; set; }
        }

        public class HoursItem
        {
            /// <summary>
            /// 10时
            /// </summary>
            public string hours { get; set; }
            /// <summary>
            /// 小雨
            /// </summary>
            public string wea { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string wea_img { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tem { get; set; }
            /// <summary>
            /// 东风
            /// </summary>
            public string win { get; set; }
            /// <summary>
            /// <3级
            /// </summary>
            public string win_speed { get; set; }
        }

        public class IndexItem
        {
            /// <summary>
            /// 紫外线指数
            /// </summary>
            public string title { get; set; }
            /// <summary>
            /// 最弱
            /// </summary>
            public string level { get; set; }
            /// <summary>
            /// 辐射弱，涂擦SPF8-12防晒护肤品。
            /// </summary>
            public string desc { get; set; }
        }

        public class DataItem
        {
            /// <summary>
            /// 18日（星期五）
            /// </summary>
            public string day { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string date { get; set; }
            /// <summary>
            /// 星期五
            /// </summary>
            public string week { get; set; }
            /// <summary>
            /// 阴
            /// </summary>
            public string wea { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string wea_img { get; set; }
            /// <summary>
            /// 小雨
            /// </summary>
            public string wea_day { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string wea_day_img { get; set; }
            /// <summary>
            /// 阴
            /// </summary>
            public string wea_night { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string wea_night_img { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tem { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tem1 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string tem2 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string humidity { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string visibility { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string pressure { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<string> win { get; set; }
            /// <summary>
            /// <3级
            /// </summary>
            public string win_speed { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string win_meter { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string sunrise { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string sunset { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string air { get; set; }
            /// <summary>
            /// 优
            /// </summary>
            public string air_level { get; set; }
            /// <summary>
            /// 空气很好，可以外出活动，呼吸新鲜空气，拥抱大自然！
            /// </summary>
            public string air_tips { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Alarm alarm { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<HoursItem> hours { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<IndexItem> index { get; set; }
        }

        public class Aqi
        {
            /// <summary>
            /// 
            /// </summary>
            public string update_time { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string cityid { get; set; }
            /// <summary>
            /// 上海
            /// </summary>
            public string city { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string cityEn { get; set; }
            /// <summary>
            /// 中国
            /// </summary>
            public string country { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string countryEn { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string air { get; set; }
            /// <summary>
            /// 优
            /// </summary>
            public string air_level { get; set; }
            /// <summary>
            /// 空气很好，可以外出活动，呼吸新鲜空气，拥抱大自然！
            /// </summary>
            public string air_tips { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string pm25 { get; set; }
            /// <summary>
            /// 优
            /// </summary>
            public string pm25_desc { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string pm10 { get; set; }
            /// <summary>
            /// 优
            /// </summary>
            public string pm10_desc { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string o3 { get; set; }
            /// <summary>
            /// 优
            /// </summary>
            public string o3_desc { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string no2 { get; set; }
            /// <summary>
            /// 优
            /// </summary>
            public string no2_desc { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string so2 { get; set; }
            /// <summary>
            /// 优
            /// </summary>
            public string so2_desc { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string co { get; set; }
            /// <summary>
            /// 优
            /// </summary>
            public string co_desc { get; set; }
            /// <summary>
            /// 不用佩戴口罩
            /// </summary>
            public string kouzhao { get; set; }
            /// <summary>
            /// 非常适宜运动
            /// </summary>
            public string yundong { get; set; }
            /// <summary>
            /// 适宜外出
            /// </summary>
            public string waichu { get; set; }
            /// <summary>
            /// 适宜开窗
            /// </summary>
            public string kaichuang { get; set; }
            /// <summary>
            /// 关闭净化器
            /// </summary>
            public string jinghuaqi { get; set; }
        }

        public class Root
        {
            /// <summary>
            /// 
            /// </summary>
            public string cityid { get; set; }
            /// <summary>
            /// 上海
            /// </summary>
            public string city { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string cityEn { get; set; }
            /// <summary>
            /// 中国
            /// </summary>
            public string country { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string countryEn { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string update_time { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<DataItem> data { get; set; }
            /// <summary>
            /// 
            /// </summary>
            //public Aqi aqi { get; set; }
        }
    }
}
