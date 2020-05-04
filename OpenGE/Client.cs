using OpenGE.Utilities;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace OpenGE
{
    namespace Network
    {
        public class Client
        {
            public void Connect(Server server)
            {
                try
                {
                    Socket socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
                    socket.Connect(new IPEndPoint(IPAddress.Parse(server.ipAddress), server.Port));
                    Debug.Log($"Connected to {server.ipAddress} on port {server.Port}...");
                }
                catch
                {
                    throw new ClientConnectionException("Failed to connect to the server.");
                }
            }
            public void Connect(int Port, string ipAddress)
            {
                try
                {
                    Socket socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
                    socket.Connect(new IPEndPoint(IPAddress.Parse(ipAddress), Port));
                    Debug.Log($"Connected to {ipAddress} on port {Port}...");
                }
                catch
                {
                    throw new ClientConnectionException("Failed to connect to the server.");
                }
            }
        }
    }
}
