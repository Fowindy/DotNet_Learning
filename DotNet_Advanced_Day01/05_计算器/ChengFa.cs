using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//8_1.导入命名空间
using Calculator;

namespace _05_计算器
{
    public class ChengFa:JiSuan
    {
        //8_3
        public ChengFa(int num1, int num2) : base(num1, num2)
        {
        }
        //8_2
        public override int GetResult()
        {
            return this.Num1 * this.Num2;
        }
    }
}
