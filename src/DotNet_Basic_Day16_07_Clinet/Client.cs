using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Clinet
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        ////07_2_2.负责通讯的Socket被多次调用,放在外面
        Socket SocketClientSend;
        //07_1.点击连接按钮开始连接
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //07_1-1.创建负责通讯的Socket
                SocketClientSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //07_1-2.拿到需要连接的目标服务器的ip地址
                IPAddress ip = IPAddress.Parse(txtServer.Text.ToString());
                //07_1-3.拿到需要连接的目标服务器的端口号
                IPEndPoint port = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text.ToString()));
                //07_1-4.开始连接
                SocketClientSend.Connect(port);
                //07_1-5.反馈连接结果
                ShowMsg("服务器:" + port + ":连接成功");
                //已连接
                btnStart.Text = "已连接";

                //07_3_7.创建一个线程
                Thread thread = new Thread(Recieve);
                thread.IsBackground = true;
                thread.Start(SocketClientSend);
            }
            catch (System.Exception ex)
            {

            }
        }

        void ShowMsg(string str)
        {
            txtLog.AppendText(str + "\r\n");
        }

        /// <summary>
        /// 07_2.客户端给服务器发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                //07_2_3.拿到需要发送的消息,Trim去除前后空格
                string msg = txtMsg.Text.Trim();
                //07_2_4.将消息解码为字节,用于传送
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(msg);
                //07_2_1.需要发送消息,需要拿到负责通讯的Socket
                SocketClientSend.Send(buffer);
                //07_2_5.客户端给服务端发送消息后,清空输入框
                txtMsg.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("该服务器已断开!", "通讯失败", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// 07_3.接收服务端发来的消息
        /// </summary>
        void Recieve(object obj)
        {
            //07_3_1.调用负责通讯的Socket
            Socket SocketClientSend = obj as Socket;
            //07_3_9.有可能报异常的地方全部异常捕获
            try
            {
                //07_3_2.不断地接收服务端发来的数据,直到接收缓存区的字节数为0
                while (true)
                {
                    //07_3_3.定义接收缓存区,并指定单次接收长度
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    //07_3_4.接收服务端发来的数据,存入接收缓存区,并获取数据的长度
                    int r = SocketClientSend.Receive(buffer);
                    //07_3_5.如果接收到的字节数为0,则退出
                    if (r == 0)
                    {
                        break;
                    }
                    //对接收到的buffer标记位进行判断,区分传过来的是什么类型的文件
                    if (buffer[0] == 0)
                    {
                        //传过来的是文本消息
                        //07_3_6.将接收到的字节解码成UTF8编码格式,方便阅读
                        //加入协议后:从第二位开始才是真实数据,长度要去掉标记位
                        string RecieveMsg = Encoding.UTF8.GetString(buffer, 1, r - 1);
                        //07_3_7.将接收到的数据显示出来
                        ShowMsg(SocketClientSend.RemoteEndPoint + ":" + RecieveMsg);
                    }
                    else if (buffer[0] == 1)
                    {
                        //传过来的是文件
                        #region 10.客户端弹出保存文件的对话框
                        //10_1.实例化保存文件对话框对象
                        SaveFileDialog sfd = new SaveFileDialog();
                        //10_2.初始化保存文件的目录
                        sfd.InitialDirectory = @"C:\Users\Administrator\Desktop";
                        //10_3.保存文件对话框的标题
                        sfd.Title = "请选择要保存的文件(自己填写后缀名)";
                        //10_4.保存文件的类型
                        sfd.Filter = "所有文件|*.*";
                        //10_5.显示对话框,需要加一个this才能弹出来
                        sfd.ShowDialog(this);
                        //10_6.获取文件名完整路径
                        string path = sfd.FileName;
                        //10_7.开始写入文件
                        using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            fsWrite.Write(buffer, 1, r - 1);
                        }
                        //10_8.弹窗显示保存文件成功
                        MessageBox.Show("保存文件成功!", "提示", MessageBoxButtons.OK);
                        #endregion
                    }
                    else if (buffer[0] == 2)
                    {
                        //传过来的是震动
                        ZD();
                    }
                }
            }
            catch (System.Exception ex)
            {

            }

        }
        /// <summary>
        /// 11.窗口震动的方法
        /// </summary>
        private void ZD()
        {
            int i = 0;
            while (i < 3)
            {
                this.Location = new Point(200, 200);
                Thread.Sleep(100);
                this.Location = new Point(400, 400);
                Thread.Sleep(100);
                i++;
            }

        }

        private void Client_Load(object sender, EventArgs e)
        {
            //07_3_8.因有多线程,界面加载屏蔽线程检查
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
