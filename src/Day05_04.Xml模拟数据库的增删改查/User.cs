/* ==============================================================================
 * 创 建 者：Fowindy
 * 创建日期：2020年9月25日 星期五 07:36:24
 * ==============================================================================*/
namespace Day05_04.Xml模拟数据库的增删改查
{
    /// <summary>
    /// 2.1.创建User类
    /// </summary>
    public class User
    {
        private string _id;
        private string _name;
        private string _passWord;

        public string Id
        {
            get => _id;
            set => _id = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string PassWord
        {
            get => _passWord;
            set => _passWord = value;
        }
    }
}