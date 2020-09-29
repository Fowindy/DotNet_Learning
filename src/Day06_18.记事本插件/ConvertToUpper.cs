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
using System.Drawing;

namespace Day06_18.记事本插件
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
        /// 3.4.对应插件功能的方法枚举
        /// </summary>
        public MethodEnum methodEnum { get => MethodEnum.StringFormat; }
        /// <summary>
        /// 3.2.插件功能:对选中字符转换处理
        /// </summary>
        /// <param name="textBox">TextBox控件</param>
        /// <returns></returns>
        public string StringFormat(RichTextBox textBox)
        {
            return textBox.Text.Replace(textBox.SelectedText, textBox.SelectedText.ToUpper());
        }
        /// <summary>
        /// 3.2.插件功能:选中字符统计处理
        /// </summary>
        /// <param name="textBox">TextBox控件</param>
        /// <returns></returns>
        public int StringCount(RichTextBox textBox)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 3.3.插件功能:设置颜色
        /// </summary>
        /// <param name="textBox"></param>
        public void SetColor(RichTextBox textBox)
        {
            throw new NotImplementedException();
        }
    }
}
