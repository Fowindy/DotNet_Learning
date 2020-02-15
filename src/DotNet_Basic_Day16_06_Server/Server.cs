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

namespace _06_Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        //06_1.开始监听按钮事件
        private void btnStart_Click(object sender, EventArgs e)
        {
            //06_4_7.凡是有可能出现异常的全部try....Catch
            try
            {
                //06_1_1.当点击开始监听的时候,在服务器端建立一个负责监听IP地址和端口号的Socket
                Socket socketServerWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //06_1_2.实例化IP地址
                IPAddress ip = IPAddress.Any;//IPAddress.Parse(txtServer.Text);
                //06_1_3.实例化端口号
                IPEndPoint port = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
                //06_1_4.绑定监听端口
                socketServerWatch.Bind(port);
                //06_1_5.反馈监听结果
                ShowMsg("监听成功");
                //已监听
                btnStart.Text = "已监听";
                //06_1_6.设置监听队列
                socketServerWatch.Listen(10);
                //06_2_5.BUG1解除:开启新线程
                Thread thread = new Thread(Listen);
                //06_2_5-1.设置线程可以后台执行
                thread.IsBackground = true;
                //06_2_5-2.传入负责监听的Socket
                thread.Start(socketServerWatch);
            }
            catch
            {

            }
        }

        //06_6.创建键值对集合,用于存储远程客户端连接过来的每一个IP地址和通讯用的Socket
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();

        /// <summary>
        /// 06_2.等待客户端的请求,并为新连接创建一个负责通讯的Socket
        /// </summary>
        /// <param name="socketServerWatch"></param>

        //06_5_4.创建一个负责通讯用的Socket,便于多次调用
        Socket socketServerSend;
        //06_2_1.思维1:Accept方法封装在Listen中,Accept方法会导致假死,因此需要将Listen开新线程
        //06_2_2.知识点1:被线程执行的方法,如果有参数的话,必须是Object类型
        void Listen(object obj)
        {
            //06_2_3.然后在方法内部将object强转为需要的参数类型
            Socket socketServerWatch = obj as Socket;
            //06_2_4.BUG2解除:可以允许多个客户端连接
            while (true)
            {
                //06_4_6.凡是有可能出现异常的全部try....Catch
                try
                {
                    //06_1_7.等待客户端的请求,并为新连接创建一个负责通讯的Socket
                    socketServerSend = socketServerWatch.Accept();
                    //06_6_1.将远程客户端的ip地址(含端口号)和通信Socket加载进键值对集合
                    dicSocket.Add(socketServerSend.RemoteEndPoint.ToString(), socketServerSend);
                    //06_6_2.并且将ip地址及端口号存入下拉框中
                    cboUsers.Items.Add(socketServerSend.RemoteEndPoint.ToString());
                    cboUsers.SelectedIndex = 1;
                    //06_1_7-1.Bug1:一直等待没有连接窗口会卡死,连接后卡死解除,卡死在Accept方法上,需开新线程
                    //06_1_7-2.Bug2:只能允许一个客户端连接过来
                    //06_1_8.反馈通讯连接结果,获取客户端IP和端口号,RemoteEndPoint中包含IP和端口
                    //192.168.3.8:11445:连接成功;
                    ShowMsg(socketServerSend.RemoteEndPoint.ToString() + ":" + "连接成功");

                    //06_4_3.开启一个新线程用于不断接收客户端发送的数据
                    Thread thread = new Thread(Recive);
                    //06_4_3-1.设置线程可以后台运行
                    thread.IsBackground = true;
                    //06_4_3-2.线程开始执行的参数
                    thread.Start(socketServerSend);
                }
                catch
                {

                }

            }
        }


        /// <summary>
        /// 06_4.服务端不断接收客户端发来的数据(解决只允许接收一个字符的bug)
        /// </summary>
        /// <param name="obj"></param>
        void Recive(object obj)
        {
            //06_4_1.将object对象强转为Socket对象
            Socket socketServerSend = obj as Socket;
            //06_4_2.放在while循环里面不断接收客户端发送的字符
            while (true)
            {
                //06_4_5.凡是有可能出现异常的全部try....Catch
                try
                {
                    //06_3_1.客户端连接成功后,服务器应该接受客户端发来的消息
                    //06_3_1-1.创建字节数组用于存储客户端发来的消息
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    //06_3_1-2.实际接收到的有效字节数
                    int r = socketServerSend.Receive(buffer);
                    //06_4_4.当客户端下线时,通过判断r是否为0来判断客户端下线,退出循环
                    if (r == 0)
                    {

                        break;
                    }
                    //06_3_1-3.将接收到的有效字节解码成UTF8编码格式
                    string str = Encoding.UTF8.GetString(buffer, 0, r);
                    //06_3_1-4.显示接收到的消息
                    ShowMsg(socketServerSend.RemoteEndPoint + ":" + str);
                }
                catch
                {
                }
            }

        }

        private void ShowMsg(string str)
        {
            //06_1_5-1.用AppendText可以将原来的也显示出来
            txtLog.AppendText(str + "\r\n");
        }

        private void Server_Load(object sender, EventArgs e)
        {
            //06_2_6.因有多线程,因此界面加载时,屏蔽跨线程的检查
            Control.CheckForIllegalCrossThreadCalls = false;
            cboUsers.SelectedIndex = 0;
        }
        /// <summary>
        /// 06_5.服务端给客户端发消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                //06_5_1.获取输入的消息
                string msg = txtMsg.Text.Trim();
                //06_5_2.将目标消息解码成二进制便于发送
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(msg);
                //创建list集合用于将标记位加载buffer数据中
                List<byte> list = new List<byte>();
                //把标记位(第一位)加载0:代表文字信息
                list.Add(0);
                //再将需要发送的buffer数据也加载进集合
                list.AddRange(buffer);
                //再将新合成的集合转换为新buffer数组类型
                byte[] newBuffer = list.ToArray();
                //06_6_3.服务器给客户端发消息前,根据从下拉框选择的ip,拿到与之对应通信用的Socket,并发送消息
                if(cboUsers.SelectedIndex > 0)
                {
                    dicSocket[cboUsers.SelectedItem.ToString()].Send(newBuffer);
                    //06_5_3.调用负责通讯用的Socket发送消息
                    //socketServerSend.Send(buffer);
                    //06_5_5.发送消息后清空输入栏
                    txtMsg.Clear();
                }
                else if (cboUsers.SelectedIndex == 0)
                {
                    MessageBox.Show("请先选择客户端", "提示", MessageBoxButtons.OK);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("该客户端已断开!", "通讯失败", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// 8.选择要发送的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            //8_1.点击选择按钮弹出选择文件对话框
            OpenFileDialog ofd = new OpenFileDialog();
            //8_2.初始化路径
            ofd.InitialDirectory = @"C:\Users\Administrator\Desktop";
            //8_3.对话框标题
            ofd.Title = "请选择要发送的文件";
            //8_4.可选择的文件格式
            ofd.Filter = "所有文件|*.*";
            //8_5.将对话框显示出来
            ofd.ShowDialog();
            //8_6.将文件名在发送框中显示
            txtPath.Text = ofd.FileName;
        }
        /// <summary>
        /// 9.发送文件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendFile_Click(object sender, EventArgs e)
        {
            //9_1.获取要发送文件的路径
            string path = txtPath.Text;
            //9_2.使用using可以自动释放资源
            //9_3.使用文件流以路径,打开,只读的方式读取文件流
            using (FileStream fsRead = new FileStream (path,FileMode.Open,FileAccess.Read))
            {
                //9_4.定义字节数组用于缓存文件字节流,每次读取5M
                byte[] buffer = new byte[1024 * 1024 * 5];
                //9_5.将文件读入buffer区
                int r = fsRead.Read(buffer, 0, buffer.Length);
                //9_6.创建list集合用于合成标记位
                List<byte> list = new List<byte>();
                //9_7.加载第一位标记位:1;表示文件
                list.Add(1);
                //9_8.然后将文件字节流合成进去
                list.AddRange(buffer);
                //9_9.将list泛型集合转回新的字节数组
                byte[] newBuffer = list.ToArray();
                //9_10.调用通信用的Socket发送文件,因为文件比较大,有可能超过5M,所以每次发5M,需要定义每次发的长度
                dicSocket[cboUsers.SelectedItem.ToString()].Send(newBuffer,0,r+1,SocketFlags.None);
            }
        }
        /// <summary>
        /// 11.发送震动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZD_Click(object sender, EventArgs e)
        {
            //11_1.震动只是一个固定长度的指令,加上标记位长度为2就好
            byte[] buffer = new byte[2];
            //11_2.设置震动的协议指定
            buffer[0] = 2;
            //11_3.调用通信的Socket发送震动
            dicSocket[cboUsers.SelectedItem.ToString()].Send(buffer);
        }
    }
}
