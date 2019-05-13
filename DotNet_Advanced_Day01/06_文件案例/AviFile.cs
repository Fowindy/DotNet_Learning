using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_文件案例
{
    public class AviFile : UserFile
    {
        public AviFile(string fileName) : base(fileName)
        {
        }

        public override void Show()
        {
            Console.WriteLine("因为该文件的后缀是:{1};所以{0}这个文件可以通过快播播放器查看.", this.FileName, this.ExtensionName);
        }
    }
}
