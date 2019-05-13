using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_文件案例
{
    public class XmlFile:UserFile
    {
        //子类继承父类的构造函数
        //代表子类先把自己的参数传到父类中,然后再调用
        public XmlFile(string fileName) : base(fileName)
        {
        }

        public override void Show()
        {
            Console.WriteLine("因为该文件的后缀是:{1};所以{0}这个文件可以通过浏览器查看.",this.FileName,this.ExtensionName);
        }
    }
}
