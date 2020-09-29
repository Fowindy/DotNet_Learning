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
    public class ConvertToLower:IEditPlus
    {
        public string Name { get => "大写转小写"; }
        public MethodEnum methodEnum { get => MethodEnum.StringFormat; }
        public string StringFormat(RichTextBox textBox)
        {
            return textBox.Text.Replace(textBox.SelectedText, textBox.SelectedText.ToLower());
        }
        public int StringCount(RichTextBox textBox)
        {
            throw new NotImplementedException();
        }

        public void SetColor(RichTextBox textBox)
        {
            throw new NotImplementedException();
        }
    }
}
