using System;
using System.Net.Sockets;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Security;
//To import: Go to "References" in solution --> Right click --> Add reference --> Search for "System.Runtime.Remoting" and check it off.

class ClientCLI
{
    public static void Main()
    {
        //The URL for the server
        string echoUrl = "tcp://localhost:9998/Echo";
        string paldindromeUrl = "tcp://localhost:9998/PalindromeChecker";

        //Register the channel
        try
        {
            TcpChannel tcpChannel = new TcpChannel();
            ChannelServices.RegisterChannel(tcpChannel, false);

            //Get the Echo remote object
            Type echoType = typeof(IEcho);
            IEcho remoteEcho = (IEcho)Activator.GetObject(echoType, echoUrl);

            //Get the PaldindromeChecker remote object
            Type palindromeCheckerType = typeof(IPalindromeChecker);
            IPalindromeChecker remotePalindromeChecker = (IPalindromeChecker)Activator.GetObject(palindromeCheckerType, paldindromeUrl);


            string input = "";
            Console.WriteLine("\nWrite a word to the server and wait for the server to check if the word is palindrome. \n (Type 'quit' to exit)");
            //Boolean flag = false;
            //while (input != "QUIT")
            while (!string.Equals(input, "quit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nEnter word to check whether it is palindrome or 'quit' to exit the program");
                input = Console.ReadLine();

                if (string.Equals(input, ""))
                {
                    Console.WriteLine("You didnt enter anything, this cannot be checked to be a palindrome, please write a word");
                    Console.WriteLine("\nEnter word to check whether it is palindrome");
                    input = Console.ReadLine();                
                }

                Console.WriteLine(remoteEcho.Send(input.Replace(" ", "").Trim()));
                Boolean palindrome = remotePalindromeChecker.isPalindrome(input.Replace(" ", "").Trim());
                Console.WriteLine("It is " + palindrome + " that the message was a palindrome.");
            }
        }
        catch (SocketException ex)
        {
            Console.WriteLine("Could not establish connection with server or a existing connection was forcefully disconnected");
            Console.WriteLine(ex.GetType().FullName);
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentNullException ex)
        {

            Console.WriteLine("The chnl parameter is null.");
            Console.WriteLine(ex.GetType().FullName);
            Console.WriteLine(ex.Message);
        }
        catch (RemotingException ex)
        {

            Console.WriteLine("The channel has already been registered.");
            Console.WriteLine(ex.GetType().FullName);
            Console.WriteLine(ex.Message);
        }
        catch (MemberAccessException ex)
        {

            Console.WriteLine("This member was invoked with a late-binding mechanism.");
            Console.WriteLine(ex.GetType().FullName);
            Console.WriteLine(ex.Message);
        }
        catch (SecurityException ex)
        {

            Console.WriteLine("At least one of the callers higher in the callstack does not have permission to configure remoting types and channels.");
            Console.WriteLine(ex.GetType().FullName);
            Console.WriteLine(ex.Message);
        }
        



    }
}
