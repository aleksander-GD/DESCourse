using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using LearningWCF;
using PalindromeService;

namespace GettingStartedHost
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create a URI to serve as the base address.
            Uri baseAddress = new Uri("http://localhost:8000/GettingStarted/");
            Uri baseAddress2 = new Uri("http://localhost:8000/Palindrome/");

            // Step 2: Create a ServiceHost instance.
            ServiceHost selfHost = new ServiceHost(typeof(CalculatorService), baseAddress);
            ServiceHost selfHost2 = new ServiceHost(typeof(PalindromeServiceFUCKER), baseAddress2);

            try
            {
                // Step 3: Add a service endpoint.
                selfHost.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "CalculatorService");
                selfHost2.AddServiceEndpoint(typeof(IPalindrome), new WSHttpBinding(), "PalindromeServiceFUCKER");
                // Step 4: Enable metadata exchange.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);
                selfHost2.Description.Behaviors.Add(smb);
                // Step 5: Start the service.
                selfHost.Open();
                selfHost2.Open();
                Console.WriteLine("The services are ready.");

                // Close the ServiceHost to stop the service.
                Console.WriteLine("Press <Enter> to terminate the service.");
                Console.WriteLine();
                Console.ReadLine();
                selfHost.Close();
                selfHost2.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                selfHost.Abort();
                selfHost2.Abort();
            }
        }
    }
}