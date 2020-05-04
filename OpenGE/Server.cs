using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace OpenGE
{
    namespace Network
    {
        public class Server
        {
            public int Port { get; private set; }
            public string ipAddress { get; private set; }
            public UdpClient recivingClient { get; private set; }

            private TcpListener listener;
            private IPEndPoint IPEndPoint;
            private byte[] recieveBuffer;
            public Server(int _Port,string _ipAddress)
            {
                Port = _Port;
                ipAddress = _ipAddress;

                recivingClient = new UdpClient(_ipAddress,_Port);
                IPEndPoint = new IPEndPoint(IPAddress.Parse(_ipAddress), Port);

                Console.WriteLine("Starting server...");

                listener = new TcpListener(IPAddress.Parse(ipAddress), Port);
                listener.Start();

                Console.WriteLine($"Server started on {Port}...");

            }
            public byte[] Listen()
            {
                recieveBuffer = recivingClient.Receive(ref IPEndPoint);

                return recieveBuffer;
            }
        }
    }
}
