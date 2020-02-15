using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadTest
{
    public partial class MultiThreadTest : Form
    {
        public MultiThreadTest()
        {
            InitializeComponent();

        }
        bool IsStart = false;
        private void ShowMsg(object obj)
        {
            while (!IsStart)
            {
                textLog.AppendText("蜂鸣器鸣叫" + "\r\n");
                Thread.Sleep(1000);
            }

        }

        private void ShowMsgBox(object obj)
        {
            if (MessageBox.Show("阻挡动点未感应", "报警", MessageBoxButtons.OK) == DialogResult.OK)
            {
                IsStart = true;
            }
        }

        private void MultiThreadTest_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread th1 = new Thread(ShowMsg);
            th1.IsBackground = true;
            th1.Start();

            Thread th2 = new Thread(ShowMsgBox);
            th2.IsBackground = true;
            th2.Start();
        }
    }
}
