/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月29日 星期二 15:41:50
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月29日 星期二 15:41:50
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using Day06_17.IEditPlus接口;
using System.Windows.Forms;

namespace Day06_18.字母转大写插件
{
    /// <summary>
    /// 3.插件实现接口
    /// </summary>
    public class ConvertToUpper:IEditPlus
    {
        /// <summary>
        /// 3.1.插件名称
        /// </summary>
        public string Name { get => "小写转大写"; }
        /// <summary>
        /// 3.2.插件功能:转换字符串为大写
        /// </summary>
        /// <param name="textBox">TextBox控件</param>
        /// <returns></returns>
        public string StringFormat(TextBox textBox)
        {
            return textBox.Text.ToUpper();
        }
        /// <summary>
        /// 3.2.此方法不作实现(不推荐一个接口多功能)
        /// </summary>
        /// <param name="textBox">TextBox控件</param>
        /// <returns></returns>
        public int StringCount(TextBox textBox)
        {
            throw new NotImplementedException();
        }
    }
}
