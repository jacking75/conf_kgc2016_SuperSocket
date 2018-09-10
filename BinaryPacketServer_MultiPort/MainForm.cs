using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryPacketServer_MultiPort
{
    public partial class MainForm : Form
    {
        System.Windows.Threading.DispatcherTimer workProcessTimer = new System.Windows.Threading.DispatcherTimer();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var server1 = new MainServer1();
            server1.InitConfig();
            server1.CreateServer();

            var IsResult = server1.Start();

            if (IsResult)
            {
                DevLog.Write(string.Format("서버1 네트워크 시작"), LOG_LEVEL.INFO);
            }
            else
            {
                DevLog.Write(string.Format("[ERROR] 서버1 네트워크 시작 실패"), LOG_LEVEL.ERROR);
                return;
            }


            var server2 = new MainServer2();
            server2.InitConfig();
            server2.CreateServer();

            var IsResult2 = server2.Start();

            if (IsResult2)
            {
                DevLog.Write(string.Format("서버2 네트워크 시작"), LOG_LEVEL.INFO);
            }
            else
            {
                DevLog.Write(string.Format("[ERROR] 서버2 네트워크 시작 실패"), LOG_LEVEL.ERROR);
                return;
            }

            workProcessTimer.Tick += new EventHandler(OnProcessTimedEvent);
            workProcessTimer.Interval = new TimeSpan(0, 0, 0, 0, 32);
            workProcessTimer.Start();
        }

        private void OnProcessTimedEvent(object sender, EventArgs e)
        {
            // 너무 이 작업만 할 수 없으므로 일정 작업 이상을 하면 일단 패스한다.
            int logWorkCount = 0;

            while (true)
            {
                string msg;

                if (DevLog.GetLog(out msg))
                {
                    ++logWorkCount;

                    if (listBoxLog.Items.Count > 100)
                    {
                        listBoxLog.Items.Clear();
                    }

                    listBoxLog.Items.Add(msg);
                    listBoxLog.SelectedIndex = listBoxLog.Items.Count - 1;
                }
                else
                {
                    break;
                }

                if (logWorkCount > 7)
                {
                    break;
                }
            }
        }
    }
}
