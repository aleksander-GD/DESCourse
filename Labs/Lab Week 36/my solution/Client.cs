using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class MainClass
    {
        private static Stream info;
        private static string answer;
        private static bool notdone = true;

        public static void Main(string[] args)
        {

            try
            {
                TcpClient cl = new TcpClient();
                Console.WriteLine("Connecting.....");
                cl.Connect("127.0.0.1", 8888);
                Console.WriteLine("Connected");

                while (notdone)
                {
                    
                    
                    Console.Write("Enter data (or quit to exit): ");

                    string information = Console.ReadLine(); // Reads the input
                    answer = information.ToUpper(); // Answer

                    if (answer == "QUIT")
                    {
                        notdone = false;    // Break loop and stop the client
                        
                    }

                    info = cl.GetStream();
                    ASCIIEncoding asen = new ASCIIEncoding();
                    byte[] ba = asen.GetBytes(information);
                    Console.WriteLine("Transmitting.....");
                    info.Write(ba, 0, ba.Length);
                    Console.WriteLine("....");
                    byte[] bb = new byte[100];
                    int k = info.Read(bb, 0, 100);

                    for (int i = 0; i < k; i++)
                        Console.Write(Convert.ToChar(bb[i]));
                    
                    
                    
                }
            } catch (SocketException)
            {
                throw;
            }


        }
        
    }
}
