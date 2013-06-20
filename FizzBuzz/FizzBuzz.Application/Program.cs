using System;
using FizzBuzz;

namespace FizzBuzz.Application
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your first number");
            int startNumber =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            int endNumber = Convert.ToInt32(Console.ReadLine());

            var fizzBuzzDataFormatter = new FizzBuzzDataFormatter();

            var fizzBuzzEngine = new FizzBuzzEngine();
            
            Console.Clear();

            Console.WriteLine(fizzBuzzDataFormatter.Format(fizzBuzzEngine.Run(startNumber, endNumber)));

            Console.ReadKey();

        }
    }
}
