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

                    TcpClient client = new TcpClient(ipAddress, Port);
                    Byte[] data = System.Text.Encoding.ASCII.GetBytes("Connection Request");
                    NetworkStream stream = client.GetStream();
                    stream.Write(data, 0, data.Length);

                    Console.WriteLine("Sent: {0}", "Connection Request");
                    data = new Byte[256];
                    String responseData = String.Empty;
                    Int32 bytes = stream.Read(data, 0, data.Length);
                    responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                    Console.WriteLine("Received: {0}", responseData);
                    stream.Close();
                    client.Close();

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
