using System;

namespace Server
{
    public class Echo : MarshalByRefObject, IEcho
    {

        public string Send(String message)
        {
            Console.WriteLine("Client sent: " + message);
            return "Server recieved: '" + message + "'";
        }
    }
}