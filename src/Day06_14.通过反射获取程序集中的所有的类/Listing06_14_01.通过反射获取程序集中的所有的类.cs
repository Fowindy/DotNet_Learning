/* ==============================================================================
 * 功能描述(Description)：
 * 
 * 作者(Author)：Fowindy
 * 
 * 日期(Create Date)：2020年9月29日 星期二 08:39:07
 * 
 * 修改记录(Revision History)：
 *      R1：
 *          修改作者：Fowindy
 *          修改日期：2020年9月29日 星期二 08:39:07
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

namespace Fowindy.Day06_14.通过反射获取程序集中的所有的类.Listing06_14_01
{
    public class Listing06_14_01
    {
        public static void Main()
        {
            //从该路径中获取指定程序集
            Assembly ass = Assembly.LoadFile(@"J:\Documents\Source\Repos\DotNet_Learning\DotNet_Advanced_Class\src\Day06_13.获取程序集\bin\Debug\Day06_13.获取程序集.dll");
            Type[] types = ass.GetTypes();
            for (int i = 0; i < types.Length; i++)
            {
                Console.WriteLine(types[i].Name);//所有类的名字
                Console.WriteLine(types[i].Namespace);//所有类的命名空间
                Console.WriteLine("---------------------------------");
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("---------------------------------");
            Type[] type1 = ass.GetExportedTypes();//获取所有的Type
            for (int i = 0; i < type1.Length; i++)
            {
                Console.WriteLine(types[i].Name);//所有类的名字
                Console.WriteLine(types[i].Namespace);//所有类的命名空间
                Console.WriteLine("---------------------------------");
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("---------------------------------");
            #region 获取指定命名空间中的公共类
            //获取指定命名空间中的公共类
            Type typePer = ass.GetType("Day06_13.获取程序集.Person");
            //获取所有的方法
            MethodInfo[] methods = typePer.GetMethods();
            //获取方法名
            for (int i = 0; i < methods.Length; i++)
            {
                Console.WriteLine(methods[i].Name);
            }
            #endregion
            Type typeStu = ass.GetType("Day06_13.获取程序集.Student");
            //判断typePer可不可以接受typeStu赋值---true
            Console.WriteLine(typePer.IsAssignableFrom(typeStu));
            object obj = Activator.CreateInstance(typeStu);
            //判断obj是不是typePer的实例---true
            Console.WriteLine(typePer.IsInstanceOfType(obj));
            //判断typeStu是不是typePer的子类
            Console.WriteLine(typeStu.IsSubclassOf(typePer));
        }
    }
}
