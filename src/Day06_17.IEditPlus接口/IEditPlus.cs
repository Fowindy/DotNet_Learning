using System;
using System.Collections.Generic;
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
        /// 2.2.接口处理TextBox字符串格式的接口
        /// </summary>
        /// <param name="textBox">TextBox控件</param>
        /// <returns>处理后的字符串</returns>
        string StringFormat(TextBox textBox);
        /// <summary>
        /// 2.2.接口计算TextBox字符个数的接口
        /// </summary>
        /// <param name="textBox">TextBox控件</param>
        /// <returns>字符数</returns>
        int StringCount(TextBox textBox);
    }
}
