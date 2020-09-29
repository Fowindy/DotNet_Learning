/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月29日 星期二 10:47:23
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月29日 星期二 10:47:23
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace Day06_13.获取程序集
{
    public class Engineer:Person
    {
        public void ShowInfo(string name)
        {
            Console.WriteLine($"我叫{name},是一名软件工程师");
        }
        public void ShowInfo(int age)
        {
            Console.WriteLine($"我是一名软件工程师,今年{age}岁");
        }
    }
}
