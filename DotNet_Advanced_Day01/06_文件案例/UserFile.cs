using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_文件案例
{
    //文件父类
    public abstract class UserFile
    {
        //既然每种文件都要获取文件名和文件的后缀名，在父类里面做
        //构造函数

        //文件名属性,存文件的名字
        public string FileName { get; set; }

        //后缀名属性,存后缀名
        public string ExtensionName { get; set; }
        //父类中只有一个有参的构造函数,子类默认调父类无参的构造函数,
        //因此子类需要继承父类的构造函数
        public UserFile(string fileName)
        {
            //需要获取文件名,用属性来存储
            this.FileName = Path.GetFileNameWithoutExtension(fileName);
            //获取后缀名,用属性来存储
            this.ExtensionName = Path.GetExtension(fileName);
        }
        //应该有一个方法，告诉用户文件可以用什么工具打开
        public abstract void Show();
    }
}
