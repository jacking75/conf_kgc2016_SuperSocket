using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryPacketClient
{
    public partial class MainForm : Form
    {
        public ClientSocket socket = new ClientSocket();

        public MainForm()
        {
            InitializeComponent();
        }


        // 에코 요청
        async void SendEcho(string echoMsg)
        {
            byte[] Body = Encoding.Unicode.GetBytes(echoMsg);

            List<byte> dataSource = new List<byte>();
            dataSource.AddRange(BitConverter.GetBytes((Int32)PACKETID.REQ_ECHO));
            dataSource.AddRange(BitConverter.GetBytes((Int16)0));
            dataSource.AddRange(BitConverter.GetBytes((Int16)0));
            dataSource.AddRange(BitConverter.GetBytes(Body.Length));
            dataSource.AddRange(Body);

            await Task.Run(() => socket.s_write(dataSource.ToArray()));
            
            labelSendEcho.Text = string.Format("{0}: {1}", DateTime.Now, echoMsg);


            Tuple<int, byte[]> recvData = null;
            await Task.Run(() => recvData = socket.s_read());

            if (recvData != null && recvData.Item1 > 0)
            {
                // 패킷 뭉쳐 오는 것은 고려하지 않았음..^^;;;
                var arySeg = new ArraySegment<byte>(recvData.Item2, 12, (recvData.Item1-8));
                string msg = System.Text.Encoding.GetEncoding("utf-16").GetString(arySeg.ToArray());
                textBoxRecvEcho.Text = msg;
            }
            else
            {
                labelConnState.Text = string.Format("{0}. 서버와 접속이 끊어졌습니다.", DateTime.Now);
            }
        }

        // 서버에 접속
        private void button2_Click(object sender, EventArgs e)
        {
            string address = textBoxIP.Text;

            if (checkBoxLocalHostIP.Checked)
            {
                address = "127.0.0.1";
            }

            int port = Convert.ToInt32(textBoxPort.Text);

            if (socket.conn(address, port))
            {
                labelConnState.Text = string.Format("{0}. 서버에 접속 중", DateTime.Now);
            }
            else
            {
                labelConnState.Text = string.Format("{0}. 서버에 접속 실패", DateTime.Now);
            }
        }

        // 서버 접속 끊기
        private void button3_Click(object sender, EventArgs e)
        {
            socket.close();
        }

        // 서버에 에코 보내기
        private void button1_Click(object sender, EventArgs e)
        {
            SendEcho(textBoxSendEcho.Text);
        }
    }


    public enum PACKETID : int
    {
        REQ_ECHO = 1,
        REQ_LOGIN = 11,
    }
}
