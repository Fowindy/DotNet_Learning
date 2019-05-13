using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Add : JiSuan
    {
        //3_4.当你调用构造函数的时候,将子类num1,num2传到父类中去了
        public Add(int num1, int num2) : base(num1, num2)
        {
        }

        //3_3.在子类中有关联
        public override int GetResult()
        {
            //3_1.可以如下写法:
            //return this.Num1 + this.Num2;
            //3_5.传入后正好是父类的,等价于如下写法:
            return base.Num1 + base.Num2;
        }
    }
}
