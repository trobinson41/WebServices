using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels.Tcp;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            //HttpChannel hc = new HttpChannel(1122);
            //TcpChannel tc = new TcpChannel(1123);
            //ChannelServices.RegisterChannel(tc, false);
            //ChannelServices.RegisterChannel(hc, false);

            ////RemotingConfiguration.RegisterWellKnownServiceType(typeof(MathLibrary.MathService), "MS", WellKnownObjectMode.Singleton);
            
            //RemotingConfiguration.RegisterActivatedServiceType(typeof(MathLibrary.MathService));

            RemotingConfiguration.Configure("Server.exe.config", false);

            Console.WriteLine("Server Started, Press Enter to stop the Server");
            Console.ReadLine();
        }
    }
}
