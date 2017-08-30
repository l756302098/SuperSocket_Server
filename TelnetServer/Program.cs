using SuperSocket.SocketBase;
using SuperSocket.SocketEngine;
using System;
using TelnetServer.Server;

namespace TelnetServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var bootstrap = BootstrapFactory.CreateBootstrap();
            if (!bootstrap.Initialize())
            {
                Console.WriteLine("Failed to initialize!");
                Console.ReadKey();
                return;
            }

            var result = bootstrap.Start();
            
            Console.WriteLine("Start result: {0}!", result);

            if (result == StartResult.Failed)
            {
                Console.WriteLine("Failed to start!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Press key 'q' to stop it!");

            while (Console.ReadKey().KeyChar != 'q')
            {
                Console.WriteLine();
                continue;
            }

            Console.WriteLine();

            //Stop the appServer
            bootstrap.Stop();

            Console.WriteLine("The server was stopped!");
            Console.ReadKey();
        }
        static void appServer_NewSessionConnected(TelnetSession session)
        {
            Console.WriteLine("Welcome to SuperSocket Telnet Server");
        }

        static void appServer_SessionClosed(TelnetSession session, CloseReason reason)
        {
            Console.WriteLine("Close one SuperSocket session ");
        }
    }
}
