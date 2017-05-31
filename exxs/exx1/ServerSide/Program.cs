using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerSide
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new EchoServer();
            server.start();
            server.stop();
        }
    }

    class EchoServer : TcpListener
    {
        public EchoServer() : base(local, port) { }

        public void start()
        {
            try
            {
                base.Start();
                Console.WriteLine("Server listen on port 13000...");

                while (true)
                {
                    var client = base.AcceptTcpClient();
                    var stream = client.GetStream();
                    Console.WriteLine("Connected!");

                    var i = 0;
                    var bytes = new byte[4096];
                    var data = "";

                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        data = Encoding.UTF8.GetString(bytes, 0, i);
                        Console.WriteLine("Receive: {0}", data);
                        data = data.TrimEnd('\0');

                        var msg = Encoding.UTF8.GetBytes(data);
                        stream.Write(msg, 0, msg.Length);
                    }
                    client.Close();
                }
            }
            catch (SocketException err)
            {
                Console.WriteLine(err);
            }
            catch (IOException)
            {
                Console.WriteLine("Connection shut by another side.");
            }
        }

        public void stop()
        {
            base.Stop();
        }

        private static int port = 13000;
        private static IPAddress local = IPAddress.Parse("127.0.0.1");
    }
}
