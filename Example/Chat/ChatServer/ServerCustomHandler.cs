
using ONetworkTalk.Handler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Google.Protobuf;
using ONetworkTalk.Contract;

namespace ChatServer
{
    public class ServerCustomHandler : ICustomizeHandler
    {

        public void Handle<T>(string sourceUserID, int contractaID, T t) where T : IMessage<T>, new()
        {
            return;
        }

        public void Handle(string sourceUserID, int contractaID, byte[] info)
        {
            if (contractaID == 1)
            {
                ChatContent chat = ChatContent.Parser.ParseFrom(info);
                Program.serverEngine.BasicController.SendAll(1,chat);
            }

            
        }

        public byte[] HandleQuery<T>(string sourceUserID, int contractaID, T t) where T : IMessage<T>, new()
        {
            throw new NotImplementedException();
        }

        public byte[] HandleQuery(string sourceUserID, int contractaID, byte[] info)
        {
            throw new NotImplementedException();
        }
    }
}