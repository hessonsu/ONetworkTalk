using DotNetty.Transport.Channels;
using ONetworkTalk.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONetworkTalk.Handler
{
    public interface IBasicHandler
    {
        bool VerifyUser(LoginContract loginContract,IChannel channel,out string failureCause);
    }
}
