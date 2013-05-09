using System;
using System.Collections.Generic;

namespace TKBoisvert.Calculus
{
    internal class UI
    {
        public static string GetSelection()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Press. . .");
                Console.WriteLine();
                Console.WriteLine("1 for factoring");
                Console.WriteLine("2 for checking factors");
                Console.WriteLine("3 for Addition Sequences & Series");
                Console.WriteLine("4 for Geometric Sequences & Series");
                Console.WriteLine();
                
                string myChoice = Console.ReadLine();

                if (myChoice == "1" || myChoice == "2" || myChoice == "3" || myChoice == "4")
                {
                    return myChoice;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Um, that isn't an option...");
                    Console.ReadKey();
                }

            }
        }

        public static Stack<double> GetABC()
        {
            Stack<double> UI = new Stack<double>();

            Console.Clear();

            Console.WriteLine("Enter A");
            UI.Push(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Enter B");
            UI.Push(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Enter C");
            UI.Push(Convert.ToDouble(Console.ReadLine()));

            return UI;
        }

        public static double GetFactor(string WhichOne, string NullOrX)
        {
            Console.WriteLine("Enter the {0}", WhichOne);

            Console.Write("{0} ", NullOrX);

            return Convert.ToDouble(Console.ReadLine());
        }
    }
}