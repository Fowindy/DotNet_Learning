﻿/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月17日 星期一 22:12:17
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Day01_07.作业_车位对应
{
    public abstract class Car
    {
        //02.01.定义品牌,型号,车库属性
        public string Brand { get; set; }
        //02.02.初始化构造函数
        public Car(string brand)
        {
            this.Brand = brand;
        }
        public abstract void GetCarGarage();
    }
}
