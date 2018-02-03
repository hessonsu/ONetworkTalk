
using ONetworkTalk.Handler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DotNetty.Transport.Channels;
using ONetworkTalk.Contract;

namespace ChatServer
{
    public class LoginHandler : IBasicHandler
    {
        public bool VerifyUser(LoginContract loginContract, IChannel channel,out string failureCause)
        {
            throw new NotImplementedException();
        }
    }
}