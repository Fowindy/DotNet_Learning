using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Sub:JiSuan
    {
        //5_2.必须要有构造函数,不然子类的属性值无法传进来
        public Sub(int num1, int num2) : base(num1, num2)
        {
        }
        //5_1.Sub方法的重写
        public override int GetResult()
        {
            return this.Num1 - this.Num2;
        }
    }
}
