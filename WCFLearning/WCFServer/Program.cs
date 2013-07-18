using System;
using System.Collections.Generic;
using System.Linq;
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

            serviceHost.AddServiceEndpoint(typeof(IFizzBuzzService), new NetNamedPipeBinding(), new Uri("net.pipe://localhost/FizzTheBuzz"));

            serviceHost.Open();

            Console.WriteLine("YOU WIN!!!!11!");

            Console.ReadKey();

            serviceHost.Close();

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
