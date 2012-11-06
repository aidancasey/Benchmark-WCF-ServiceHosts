using System;
using System.ServiceModel;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceHost serviceHost = new ServiceHost(typeof(ServiceImplementation.SampleServiceImplementation));

            serviceHost.Open();
            Console.WriteLine("listening");
            Console.ReadLine();

        }
    }
}
