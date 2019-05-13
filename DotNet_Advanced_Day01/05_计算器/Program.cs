using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//6_1.第一种导入类库命名空间,也等价于6_1-1
using Calculator;

namespace _05_计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            //控制台形式的计算器
            Console.Write("请输入第一个数:");
            int num1 = Convert.ToInt32(Console.ReadLine());//可能会报异常
            Console.Write("请输入第二个数:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入一个操作符(+,-,*,/):");
            string opt = Console.ReadLine();//符号

            //6_1-1.
            //Calculator.Add()

            //7_1.JiSuan父类实例化(新建一个方法)
            JiSuan js = GetJiSuanByNumberAndOpt(opt, num1, num2);
            //7_3.判断实例是否为空
            if (js != null)
            {
                //7_3_1.开始调用JiSuan中获取结果的方法GetResult()
                int Result = js.GetResult();
                //7_3_2.打印结果
                Console.WriteLine(Result);
                Console.ReadKey();
            }
            //类---类库的方式
        }

        //7_2.生成一个方法
        private static JiSuan GetJiSuanByNumberAndOpt(string opt, int num1, int num2)
        {
            //7_2_1.错误1.抽象类不能实例化---为了多态
            //JiSuan js = new JiSuan();

            //7_2_2.正确1.一个对象等于null,代表这个对象在栈空间没有堆里面的地址
            JiSuan js = null;
            //7_2_3.判断操作符,进行相应计算
            switch (opt)
            {
                case "+":js = new Add(num1,num2);break;
                case "-":js = new Sub(num1, num2);break;
                //8_4.乘法
                case "*":js = new ChengFa(num1, num2);break;
            }
            return js;

            //9_1.附加题:还可以通过: 反射
        }
    }
}
