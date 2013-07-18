using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using WCFContract;
using FizzBuzz;
using System.ServiceModel;

namespace WCFServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost serviceHost = new ServiceHost(typeof (FizzBuzzService));

            ServiceEndpoint serviceEndpoint = serviceHost.AddServiceEndpoint(typeof(IFizzBuzzService), GetBinding(), GetAddress());

            //ServiceMetadataBehavior serviceMetadataBehavior = new ServiceMetadataBehavior
            //    {
            //        HttpGetEnabled = true,
            //        HttpGetUrl = new Uri("http://localhost:8888/FizzTheBuzz/Wsdl")
            //    };

            //serviceHost.Description.Behaviors.Add(serviceMetadataBehavior);

            serviceHost.Open();

            Console.WriteLine("YOU WIN!!!!11!");

            Console.ReadKey();

            serviceHost.Close();
        }

        private static Uri GetAddress()
        {
            //return new Uri("http://localhost:8888/FizzTheBuzz");
            return new Uri("net.pipe://localhost/FizzTheBuzz");
        }

        private static Binding GetBinding()
        {
            //return new BasicHttpBinding();
            return new NetNamedPipeBinding();
        }
    }
    class FizzBuzzService : IFizzBuzzService
    {
        public string FizzTheBuzz(int startnumber, int endNumber)
        {
            Console.WriteLine("FizzBuzz Engine had been called with {0} and {1}", startnumber, endNumber);

            FizzBuzzEngine fizzBuzzEngine = new FizzBuzzEngine();

            FizzBuzzDataFormatter fizzBuzzFormatter = new FizzBuzzDataFormatter();

            return fizzBuzzFormatter.Format(fizzBuzzEngine.Run(startnumber, endNumber));

        }
    }
}
