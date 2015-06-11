using System;
using System.ServiceModel;

namespace WCFServiceWithAzureServiceBusQueue.Host
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.Title = "MyQueuedService Service";
                Console.WriteLine("Ready to receive messages from Azure Service Bus queue.");


                var serviceHost = new ServiceHost(typeof (MyQueuedService));

                serviceHost.Open();

                Console.WriteLine("\nPress [Enter] to close ServiceHost.");
                Console.ReadLine();

                serviceHost.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception occurred: {0}", exception);
                Console.WriteLine("\nPress [Enter] to exit.");
                Console.ReadLine();
            }
            Console.WriteLine("\nPress [Enter] to exit.");
            Console.ReadLine();
        }
    }
}