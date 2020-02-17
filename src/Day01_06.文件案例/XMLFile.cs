/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月17日 星期一 17:33:45
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day01_06.文件案例
{
    //04.01.XML子类继承父类,并实现抽象方法
    public class XMLFile:UserFile
    {
        public XMLFile(string allFileName) : base(allFileName)
        {
        }

        public override void ShowResult()
        {
            Console.WriteLine("{0}:这个文件后缀为{1},可以通过浏览器查看", this.AllFileName, this.ExtensionName);
        }
    }
}
