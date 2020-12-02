﻿using NUnit.Framework.Constraints;
using RosSharp.RosBridgeClient;
using RosSharp.RosBridgeClient.MessageTypes.Std;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RosBridgeClientTest
{
    public class RosCommTest
    {
        static string LastMsg = "None";
        static string publishId;
        static RosSocket rosSocket;

        public static void Main(string[] args)
        {
            //string uri = "ws://localhost:9090";


            Thread thread = new Thread(DoWork);
            thread.Start();

            //while(Console.ReadLine() != "e")
            //{
            //    Console.WriteLine(LastMsg);
            //}


            Console.ReadLine();
        }



        private static void OnClosed(object sender, EventArgs e)
        {
            Console.WriteLine("Closed");
        }

        private static void OnConnected(object sender, EventArgs e)
        {
            Console.WriteLine("Yes!");
        }

        private static void DoWork()
        {
            string uri = "ws://localhost:9090";

            Console.WriteLine($"Trying to connect to RosBridge via {uri}");
            RosSharp.RosBridgeClient.Protocols.WebSocketNetProtocol webSocketNetProtocol = new RosSharp.RosBridgeClient.Protocols.WebSocketNetProtocol(uri);
            var protocol = RosSharp.RosBridgeClient.Protocols.ProtocolInitializer.GetProtocol(RosSharp.RosBridgeClient.Protocols.Protocol.WebSocketNET, uri);
            protocol.OnConnected += OnConnected;
            protocol.OnClosed += OnClosed;
            rosSocket = new RosSocket(protocol, RosSocket.SerializerEnum.Newtonsoft_JSON);
            rosSocket.Subscribe<Clock>("/clock", ReceiveMessage,1000);
            publishId = rosSocket.Advertise<Clock>("/customTopic_clock");
            //rosSocket.Subscribe<RosSharp.RosBridgeClient.MessageTypes.Std.String>("/clock", ReceiveMessage);
        }

        private static void ReceiveMessage(Clock msg)
        {
            LastMsg = "secs " + msg.clock.secs;
            Console.WriteLine(LastMsg);
            rosSocket.Publish(publishId, new Clock()
            {
                clock = new Time(10, 20),
            });
        }


    }


    public class Clock : Message
    {
        public override string RosMessageName => "rosgraph_msgs/Clock";

        public Time clock;
    }
}