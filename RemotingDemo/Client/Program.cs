using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels.Tcp;
using MathLibrary;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ////HttpChannel hc = new HttpChannel(0);
            //TcpChannel tc = new TcpChannel();
            //ChannelServices.RegisterChannel(tc, false);
            ////ChannelServices.RegisterChannel(hc, false);

            //RemotingConfiguration.RegisterWellKnownClientType(typeof(MathService), "TCP://localhost:1123/MS");

            ////RemotingConfiguration.RegisterActivatedClientType(typeof(MathService),"tcp://localhost:1123");

            RemotingConfiguration.Configure("Client.exe.config", false);
            MathService proxy = new MathService();
            Console.WriteLine(proxy.Add(10, 20));
            Console.WriteLine(proxy.Sub(20,10));
            Console.WriteLine(proxy.GetCount());
        }
    }
}
