using System;
using TweetTest.core;
using System.Threading;


namespace TweetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                StartProcessing.StartValidation();

                Thread.Sleep(5000);

                Console.Clear();
            }
        }
    }
}
