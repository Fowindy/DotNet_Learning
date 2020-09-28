using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day06_10.委托三连击_事件实现
{
    /// <summary>
    /// 声明一个委托
    /// </summary>
    public delegate void MyDel();
    public partial class UserThreeClick_Event : UserControl
    {
        public UserThreeClick_Event()
        {
            InitializeComponent();
        }
        //声明一个委托事件---在委托前加上event关键字即可
        public event MyDel _mdl;
        int n = 0;
        private void ThreeClick_Click(object sender, EventArgs e)
        {
            n++;
            if (n == 3)
            {
                n = 0;
                if (this._mdl != null)
                {
                    this._mdl();
                }
            }
        }
    }
}
