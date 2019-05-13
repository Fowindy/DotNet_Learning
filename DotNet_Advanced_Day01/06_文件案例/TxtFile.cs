using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_文件案例
{
    public class TxtFile : UserFile
    {
        public TxtFile(string fileName) : base(fileName)
        {
        }

        public override void Show()
        {
            Console.WriteLine("因为该文件的后缀是:{1};所以{0}这个文件可以通过记事本查看.", this.FileName, this.ExtensionName);
        }
    }
}
