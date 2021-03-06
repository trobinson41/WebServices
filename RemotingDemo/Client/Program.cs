﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            ////HttpChannel hc = new HttpChannel();
            ////ChannelServices.RegisterChannel(hc, false);
            //TcpChannel tc = new TcpChannel();
            //ChannelServices.RegisterChannel(tc, false);

            //RemotingConfiguration.RegisterWellKnownClientType(typeof(MathService), "TCP://localhost:1123/MS");
            ////RemotingConfiguration.RegisterActivatedClientType(typeof(MathService), "TCP://localhost:1123");

            RemotingConfiguration.Configure("Client.exe.config", false);

            MathService proxy = new MathService();
            Console.WriteLine("20 + 10 = " + proxy.Add(20, 10));
            Console.WriteLine("20 - 10 = " + proxy.Sub(20, 10));
            Console.WriteLine("Count: " + proxy.GetCounter());

            Console.ReadLine();
        }
    }
}
