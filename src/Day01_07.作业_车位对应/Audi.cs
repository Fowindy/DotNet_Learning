/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月17日 星期一 22:38:49
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day01_07.作业_车位对应
{
    public class Audi:Car
    {
        public Audi(string brand) : base(brand)
        {
        }

        public override void GetCarGarage()
        {
            Console.WriteLine("您的车品牌为:{0},您的车应该放在二号车库,该车为:{0}A8", this.Brand);
        }
    }
}
