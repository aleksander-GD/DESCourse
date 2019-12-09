using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp; //To import: Go to "References" in solution --> Right click --> Add reference --> Search for "System.Runtime.Remoting" and check it off.

	class Program
	{
		static void Main(string[] args)
		{
			EchoServer();
		}

		static void EchoServer()
		{
            Console.WriteLine("Demo Server started...");

            //Create and register the channel
            TcpChannel tcpChannel = new TcpChannel(9998);
            ChannelServices.RegisterChannel(tcpChannel, false);

            //Register the Echo class as singleton
            Type echoType = Type.GetType("Echo");
            RemotingConfiguration.RegisterWellKnownServiceType(echoType, "Echo", WellKnownObjectMode.Singleton);

            //Register the PalindromeChecker as singleton
            Type palindromeCheckerType = Type.GetType("PalindromeChecker");
            RemotingConfiguration.RegisterWellKnownServiceType(palindromeCheckerType, "PalindromeChecker", WellKnownObjectMode.Singleton);

            System.Console.WriteLine("Press ENTER to quit");
            System.Console.ReadLine();
    }

}