using System;
using System.ServiceModel.Channels;
using System.ServiceModel;
using WCFContract;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ChannelFactory<IFizzBuzzService> channelFactory = new ChannelFactory<IFizzBuzzService>(GetBinding()))
            {
                IFizzBuzzService fizzBuzzService = channelFactory.CreateChannel(new EndpointAddress(GetEndpointAddress()));

                Console.WriteLine(fizzBuzzService.FizzTheBuzz(1, 100));

                Console.ReadLine();
            }
        }

        private static Binding GetBinding()
        {
            //return new BasicHttpBinding();
            return new NetNamedPipeBinding();
        }

        private static string GetEndpointAddress()
        {
            //return "http://localhost:8888/FizzTheBuzz";
            return "net.pipe://localhost/FizzTheBuzz";
        }
    }
}
