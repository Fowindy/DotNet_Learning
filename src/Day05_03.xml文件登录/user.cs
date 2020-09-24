/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年9月24日 星期四 23:57:16
 * ==============================================================================*/
namespace Day05_03.xml文件登录
{
    /// <summary>
    /// 2.1.5.1.创建user类
    /// </summary>
    public class user
    {
        private string _name;
        private string _id;
        private string _passWord;

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Id
        {
            get => _id;
            set => _id = value;
        }
        public string PassWord
        {
            get => _passWord;
            set => _passWord = value;
        }
    }
}