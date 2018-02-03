using ONetworkTalk.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient
{
    public class ClientCustomizeHandler : ICustomizeHandler
    {
        public void Handle(string sourceUserID, int contractaID, byte[] info)
        {
            return;
        }

        public byte[] HandleQuery(string sourceUserID, int contractaID, byte[] info)
        {
            return new byte[] { };
        }
    }
}
