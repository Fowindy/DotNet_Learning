using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day06_09.委托三连击
{
    /// <summary>
    /// 自定义声明的委托
    /// </summary>
    public delegate void MyDelegate();
    public partial class UserThreeClick : UserControl
    {
        public UserThreeClick()
        {
            InitializeComponent();
        }
        int n = 0;
        public MyDelegate _mdl;
        private void ThreeClick_Click(object sender, EventArgs e)
        {
            n++;
            if (n == 3)
            {
                if (this._mdl != null)
                {
                    this._mdl();
                }
            }
        }
    }
}
