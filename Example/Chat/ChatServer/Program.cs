using ONetworkTalk.Core;
using System;

namespace ChatServer
{
    class Program
    {
        public static OServerEngine serverEngine;
        static void Main(string[] args)
        {
            Console.WriteLine("服务端启动!");
            serverEngine = new OServerEngine();
            LoginHandler loginHandler = new LoginHandler();
            ServerCustomHandler serverCustomHandler = new ServerCustomHandler();
            serverEngine.RunEngineAsync(18888, loginHandler, serverCustomHandler);
            do {
                string common = Console.ReadLine();
                if (common.ToLower() == "bey")
                {
                    serverEngine.Close();
                    Console.WriteLine("关闭服务端");
                    break;
                }
            } while (true);
        }
    }
}
