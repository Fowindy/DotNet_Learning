/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月24日 星期四 16:25:14
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月24日 星期四 16:25:14
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace Fowindy.Day05_01.写xml文件.Listing05_01_01
{
    public class Listing05_01_01
    {
        public static void Main()
        {
            //1.实例化xml文件对象
            XDocument xdoc = new XDocument();
            #region 往xdoc对象中添加元素
            //2.实例化元素对象school(创建根节点)
            XElement school = new XElement("school");
            //3.实例化元素对象grade1(创建节点)
            XElement grade1 = new XElement("grade1");
            //3.1 设置年级属性
            grade1.SetAttributeValue("gradeNum", "1");
            //4.实例化元素对象class1(创建节点)
            XElement class1 = new XElement("class1");
            //4.1 设置班级属性
            class1.SetAttributeValue("classNum", "2");
            #region 5.学生对象
            //5.1 实例化元素对象student1(创建节点)
            XElement student1 = new XElement("student1");
            //5.1.1 设置学生学号属性
            student1.SetAttributeValue("id", "101");
            //5.1.2 设置学生姓名元素
            student1.SetElementValue("name", "刘备");
            //5.1.3 设置学生性别元素
            student1.SetElementValue("gender", "男");
            //5.1.4 设置学生年龄元素
            student1.SetElementValue("age", "16");

            //5.2 实例化元素对象student2(创建节点)
            XElement student2 = new XElement("student2");
            //5.2.1 设置学生学号属性
            student2.SetAttributeValue("id", "102");
            //5.2.2 设置学生姓名元素
            student2.SetElementValue("name", "关羽");
            //5.2.3 设置学生性别元素
            student2.SetElementValue("gender", "男");
            //5.2.4 设置学生年龄元素
            student2.SetElementValue("age", "18");
            #endregion
            //把学生对象加载到班级
            class1.Add(student1);
            class1.Add(student2);

            //把班级对象加载到年级
            grade1.Add(class1);

            //把年级对象加载到学校
            school.Add(grade1);

            //把学校对象加载到xml对象
            xdoc.Add(school);

            //保存xml对象到指定路径
            xdoc.Save(@"..\..\..\相关资料\学校分布.xml");
            #endregion
            Console.WriteLine("保存成功!");
        }
    }
}
