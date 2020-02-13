/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2019年12月3日 星期二 15:54:52
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.DotNet_Basic_Day22.Listing22_10
{
    //声明一个委托指向一个函数
    public delegate void DelSayHiI(string name);
    public class Listing22_10
    {
        public static void Main()
        {
            //只希望调一个方法,实现两种打招呼
            #region 第一种方法
            //DelSayHiI del = new DelSayHiI(SayHiChinese);
            //SayHiTest("张三", del); 
            #endregion

            #region 第二种方法
            //我们可以将一个函数赋值给一个委托对象,但必须委托和函数有相同的签名(传值类型一样)
            //DelSayHiI del = SayHiChinese;
            //SayHiTest("李四", del);
            #endregion

            #region 第三种写法
            SayHiTest("张三", SayHiChinese);
            SayHiTest("李四", SayHiEnglish);
            #endregion

            #region 第四种写法_比第三种委托方法调用方便
            SayHiChinese("王五");
            SayHiEnglish("ZhaoLiu");
            #endregion
        }
        /// <summary>
        /// 需要向方法中传名字和传打招呼的方法,传打招呼的方法使用委托类型
        /// </summary>
        /// <param name="name"></param>
        public static void SayHiTest(string name, DelSayHiI del)
        {
            //调用
            del(name);
        }
        /// <summary>
        /// 中国式的打招呼方法
        /// </summary>
        /// <param name="name"></param>
        public static void SayHiChinese(string name)
        {
            Console.WriteLine("吃了吗?" + name);
        }
        /// <summary>
        /// 美国式的打招呼方法
        /// </summary>
        /// <param name="name"></param>
        public static void SayHiEnglish(string name)
        {
            Console.WriteLine("Nice to meet you," + name);
        }
    }
}
