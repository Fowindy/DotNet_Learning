using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day06_17.IEditPlus接口
{
    /// <summary>
    /// 2.创建IEditPlus接口类
    /// </summary>
    public interface IEditPlus
    {
        /// <summary>
        /// 2.1.接口允许插件指定插件名称(接口只读取插件名称)
        /// </summary>
        string Name { get; }
        /// <summary>
        /// 2.5.方法枚举变量
        /// </summary>
        MethodEnum methodEnum { get; }
        /// <summary>
        /// 2.2.接口处理TextBox字符串格式的接口方法
        /// </summary>
        /// <param name="textBox">TextBox控件</param>
        /// <returns>处理后的字符串</returns>
        string StringFormat(RichTextBox textBox);
        /// <summary>
        /// 2.2.接口计算TextBox选中字符个数的接口方法
        /// </summary>
        /// <param name="textBox">TextBox控件</param>
        /// <returns>字符数</returns>
        int StringCount(RichTextBox textBox);
        /// <summary>
        /// 2.3.改变选中文字背景色的接口方法
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        void SetColor(RichTextBox textBox);
    }
    /// <summary>
    /// 2.4方法枚举
    /// </summary>
    public enum MethodEnum
    {
        StringFormat,
        StringCount,
        SetColor
    }
}
