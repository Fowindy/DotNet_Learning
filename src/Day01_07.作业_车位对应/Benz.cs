/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月17日 星期一 22:35:43
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day01_07.作业_车位对应
{
    public class Benz:Car
    {
        public Benz(string brand) : base(brand)
        {
        }

        public override void GetCarGarage()
        {
            Console.WriteLine("您的车品牌为:{0},您的车应该放在一号车库,该车为:{0}S6", this.Brand);
        }
    }
}
