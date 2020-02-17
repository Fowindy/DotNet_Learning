/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月17日 星期一 17:34:45
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Day01_06.文件案例
{
    ///<![CDATA[05.01.父类与子类相关分析如下:
    ///         1.无论是父类还是子类,用户都会传过来一个文件的名字;
    ///         2.在每个类里面获取这个文件的名字和文件的后缀名;(既然每个类里面都有此动作,抽象到父类中)]]>
    public abstract class UserFile
    {
        //05.02.定义文件名和后缀名存储变量属性
        public string FileName { get; set; }
        public string ExtensionName { get; set; }
        //05.03.初始化构造函数,给属性赋值
        public UserFile(string allFileName)
        {
            this.FileName = Path.GetFileName(allFileName);
            this.ExtensionName = Path.GetExtension(allFileName);
        }
    }
}
