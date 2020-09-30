using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day06_04.模态化传值
{
    public partial class MyDialog : Form
    {
        public event EventHandler TextBoxChanged;
        public string TextBoxValue
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public MyDialog() : this("") { }
        public MyDialog(string Param)
        {
            InitializeComponent();
            TextBoxValue = Param;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxChanged != null)
                TextBoxChanged(this, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
