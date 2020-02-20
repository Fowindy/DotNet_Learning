﻿/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年2月20日 星期四 19:33:51
 * ==============================================================================*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Fowindy.Day03_02.集合.Listing01_01
{
    public class Listing01_01
    {
        public static void Main()
        {
            #region 非泛型集合
            //01_ArrayList集合_必须先导入命名空间_集合中存的元素的个数可以不固定
            ArrayList arrayList = new ArrayList();
            //02_arrayList.Add存进去的时候都隐式的转换成了object类型,取出来的时候必须要进行转换,比较麻烦;比较少用ArrayList
            //03_Hashtable以键值对的方式存值,因为存值是object,取出时必须进行转换
            Hashtable ht = new Hashtable();
            ht.Add("王岳", 17786508658);
            //04_ArrayList和Hashtable属于非泛型集合_用得比较少
            //05_集合规律_一般情况添加元素的时候都会使用add方法 
            #endregion
        }
    }
}
