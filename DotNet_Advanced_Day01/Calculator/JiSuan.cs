using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class JiSuan
    {
        //自动属性
        public int Num1 { get; set; }
        public int Num2 { get; set; }


        //每一个类都隐式默认带一个不带参数的构造函数
        //当显示命名一个构造函数,则不带参数的隐式构造函数没有了
        //构造函数初始化
        public JiSuan(int num1,int num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
        }
        //3_2.需改成这样
        public abstract int GetResult();
    }
}
