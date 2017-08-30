using log4net;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelnetServer.Server;

namespace TelnetServer.Command
{
    public class LOGIN : CommandBase<TelnetSession, StringRequestInfo>
    {
        public override void ExecuteCommand(TelnetSession session, StringRequestInfo requestInfo)
        {
            Console.WriteLine("LOGIN  >>>>>  INFO :" + requestInfo.Body);
            session.Send("LOGIN SUCCESS");
        }
    }
}
