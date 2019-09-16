using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

public class Server
{
    private IPAddress ipAddress;
    private TcpListener listener;
    private Socket s;

    public Server()
    {
        ipAddress = IPAddress.Parse("127.0.0.1");
        listener = new TcpListener(ipAddress, 8888);
    }

    private void Stop()
    {
        s.Close();          // Close socket connection and releases all resources
        listener.Stop();    // Closes the listener
    }

    private void Start()
    {
        try
        {
            listener.Start();
            Console.WriteLine("Server: open port 8888...");
            Console.WriteLine("End point is :" + listener.LocalEndpoint);
            s = listener.AcceptSocket();
            while (true)
            {
                var information = new StringBuilder();

                

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
                //string getMessageFromClient = information;
                
                    
                
                

                

            }
        }
        catch (SocketException e)
        {

            
            Console.WriteLine("socket exception: ", e.Message);
            throw;
          
                
        } catch (InvalidOperationException e)
        {

            Console.WriteLine("Invalid operation exception: ", e.Message);
            throw;
            
        }
        finally
        {
            if (s.Connected == false)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Clieant closed EXITING ....");
                Thread.Sleep(1000);
                Environment.Exit(0);

            }
        }


    }


    public static void Main()
    {
        Server server = new Server();
        server.Start();

        
    }
}



