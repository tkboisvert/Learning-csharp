using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using WCFContract;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ChannelFactory<IFizzBuzzService> channelFactory = new ChannelFactory<IFizzBuzzService>(new NetNamedPipeBinding()))
            {
                IFizzBuzzService fizzBuzzService = channelFactory.CreateChannel(new EndpointAddress("net.pipe://localhost/FizzTheBuzz"));

                Console.WriteLine(fizzBuzzService.FizzTheBuzz(1, 100));

                Console.ReadLine();
            }
        }
    }
}
