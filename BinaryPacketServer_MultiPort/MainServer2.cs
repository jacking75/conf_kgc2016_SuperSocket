using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.CompilerServices;
using System.Diagnostics;

using SuperSocket.SocketBase.Logging;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
using SuperSocket.SocketBase.Config;

namespace BinaryPacketServer_MultiPort
{
    class MainServer2 : AppServer<NetworkSession2, EFBinaryRequestInfo>
    {
        Dictionary<int, Action<NetworkSession2, EFBinaryRequestInfo>> HandlerMap = new Dictionary<int, Action<NetworkSession2, EFBinaryRequestInfo>>();
        CommonHandler CommonHan = new CommonHandler();

        IServerConfig m_Config;


        public MainServer2()
            : base(new DefaultReceiveFilterFactory<ReceiveFilter, EFBinaryRequestInfo>())
        {
            NewSessionConnected += new SessionHandler<NetworkSession2>(OnConnected);
            SessionClosed += new SessionHandler<NetworkSession2, CloseReason>(OnClosed);
            NewRequestReceived += new RequestHandler<NetworkSession2, EFBinaryRequestInfo>(RequestReceived);
        }


        void RegistHandler()
        {
            HandlerMap.Add((int)PACKETID.REQ_ECHO, CommonHan.RequestEcho);

            DevLog.Write(string.Format("핸들러 등록 완료"), LOG_LEVEL.INFO);
        }

        public void InitConfig()
        {
            m_Config = new ServerConfig
            {
                Port = 32452,
                Ip = "Any",
                MaxConnectionNumber = 100,
                Mode = SocketMode.Tcp,
                Name = "BoardServerNet"
            };
        }

        public void CreateServer()
        {
            bool bResult = Setup(new RootConfig(), m_Config, logFactory: new Log4NetLogFactory());

            if (bResult == false)
            {
                DevLog.Write(string.Format("[ERROR] 서버 네트워크 설정 실패 ㅠㅠ"), LOG_LEVEL.ERROR);
                return;
            }

            RegistHandler();

            DevLog.Write(string.Format("서버 생성 성공"), LOG_LEVEL.INFO);
        }

        public bool IsRunning(ServerState eCurState)
        {
            if (eCurState == ServerState.Running)
            {
                return true;
            }

            return false;
        }

        void OnConnected(NetworkSession2 session)
        {
            DevLog.Write(string.Format("ListenPort{0}, 세션 번호 {1} 접속", m_Config.Port, session.SessionID), LOG_LEVEL.INFO);
        }

        void OnClosed(NetworkSession2 session, CloseReason reason)
        {
            DevLog.Write(string.Format("세션 번호 {0} 접속해제: {1}", session.SessionID, reason.ToString()), LOG_LEVEL.INFO);
        }

        void RequestReceived(NetworkSession2 session, EFBinaryRequestInfo reqInfo)
        {
            DevLog.Write(string.Format("세션 번호 {0} 받은 데이터 크기: {1}, ThreadId: {2}", session.SessionID, reqInfo.Body.Length, System.Threading.Thread.CurrentThread.ManagedThreadId), LOG_LEVEL.INFO);
            
            var PacketID = reqInfo.PacketID;
            var value1 = reqInfo.Value1;
            var value2 = reqInfo.Value2;

            if (HandlerMap.ContainsKey(PacketID))
            {
                HandlerMap[PacketID](session, reqInfo);
            }
            else
            {
                DevLog.Write(string.Format("세션 번호 {0} 받은 데이터 크기: {1}", session.SessionID, reqInfo.Body.Length), LOG_LEVEL.INFO);
            }
        }
    }


    public class NetworkSession2 : AppSession<NetworkSession2, EFBinaryRequestInfo>
    {
    }
}
