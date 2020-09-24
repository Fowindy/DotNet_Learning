/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月18日 星期五 13:22:05
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月18日 星期五 13:22:05
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace Fowindy.Day04_04_01.爬取天气数据_API_GET方式.AeraCode
{
    public class AeraCode
    {
        public class ZoneItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string id { get; set; }
            /// <summary>
            /// 江苏
            /// </summary>
            public string name { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string code { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<ZoneItem> zone { get; set; }
        }

        public class RootArea
        {
            /// <summary>
            /// 
            /// </summary>
            public string name { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<ZoneItem> zone { get; set; }
        }
    }
}
