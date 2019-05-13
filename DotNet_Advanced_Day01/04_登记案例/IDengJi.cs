using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_登记案例
{
    //1.接口命名规范:以I开头(也可以不用)
    //2.接口的访问修饰符:internal(默认,当前程序集),也可以加public
    interface IDengJi
    {
        #region 04_登记案例_易错知识点1
        //错误1. 修饰符“public”对该项无效
        //---接口中的成员不需要写访问修饰符,默认就是public;接口是为了多态;

        //错误2.	“IDengJi.DengJi()”: 接口成员不能有定义
        //---接口的成员不能有实现;接口是为了多态;实现虚方法抽象方法;
        //04_登记案例_易错知识点1_正确做法
        void DengJi();
        #endregion
    }
}
