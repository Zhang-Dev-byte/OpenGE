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

            Socket socket;
            UdpClient client;
            public void Connect(Server server)
            {
                try
                {
                    socket = new Socket(SocketType.Dgram, ProtocolType.Udp);
                    client = new UdpClient(server.ipAddress, server.Port);


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
                    socket = new Socket(SocketType.Dgram, ProtocolType.Udp);
                    client = new UdpClient(ipAddress, Port);

                    socket.Connect(new IPEndPoint(IPAddress.Parse(ipAddress), Port));

                    Debug.Log($"Connected to {ipAddress} on port {Port}...");
                }
                catch
                {
                    throw new ClientConnectionException("Failed to connect to the server.");
                }
            }
            public void Disconnect(){
                socket.Close();
            }
        }
    }
}
