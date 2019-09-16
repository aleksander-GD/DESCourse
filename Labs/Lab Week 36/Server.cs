using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

public class Server
{
    public static void Main()
    {
        IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
        TcpListener l = new TcpListener(ipAddress, 8888);

        while (true)
        {
            var information = new StringBuilder();

                l.Start();
                Console.WriteLine("Server: open port 8888...");
                Console.WriteLine("End point is :" + l.LocalEndpoint);
                Socket s = l.AcceptSocket();
                byte[] info = new byte[100];
                int x = s.Receive(info);
                for (int i = 0; i < x; i++)
                    {
                    information.Append(Convert.ToChar(info[i]));
                    }
                Console.Write(information);
                ASCIIEncoding asciiData = new ASCIIEncoding();
                s.Send(asciiData.GetBytes("Message recieved by the server."));
                Console.WriteLine("\nAcknowledgement Sent");
                s.Close();
                l.Stop();
               
        }
    }

}

