/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月29日 星期二 10:05:39
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月29日 星期二 10:05:39
 *          修改理由：创建文档
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Reflection;

namespace Fowindy.Day06_15.反射的应用.Listing06_15_01
{
    public class Listing06_15_01
    {
        public static void Main()
        {
            Assembly ass = Assembly.LoadFile(@"J:\Documents\Source\Repos\DotNet_Learning\DotNet_Advanced_Class\src\Day06_13.获取程序集\bin\Debug\Day06_13.获取程序集.dll");
            Type[] types = ass.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine(type.Namespace);
                Console.WriteLine(type.Name);
                MethodInfo[] methods = type.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine(method.Name);
                }
                Console.WriteLine("---------------------------------");
            }
            Type typeStu = ass.GetType("Day06_13.获取程序集.Student");
            //代表调用Show方法=>也可以设置参数类型
            MethodInfo methodStu = typeStu.GetMethod("Show",System.Type.EmptyTypes);
            object objStu = Activator.CreateInstance(typeStu);
            methodStu.Invoke(objStu, null);//该方法无参数=>设置参数

            //反射获取dll中方法内容_带参数
            Type typeEng = ass.GetType("Day06_13.获取程序集.Engineer");
            MethodInfo methodEng = typeEng.GetMethod("ShowInfo", new Type[] { typeof(string) });
            object objEng = Activator.CreateInstance(typeEng);
            methodEng.Invoke(objEng, new object[] { "王岳" });
            Console.WriteLine("----------------反射获取dll中方法内容_带参数_重载----------------");
            MethodInfo methodEng1 = typeEng.GetMethod("ShowInfo",new Type[] { typeof(int)});
            object objEng1 = Activator.CreateInstance(typeEng);
            methodEng1.Invoke(objEng, new object[] { 23 });
        }
    }
}
