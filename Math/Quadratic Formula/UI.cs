using System;
using System.Collections.Generic;

namespace Quadratic_Formula
{
    internal class UI
    {
        public static string GetSelection()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter 1 for factoring, enter 2 for checking factors");
                string myChoice = Console.ReadLine();
                if (myChoice == "1" || myChoice == "2")
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

        public static Stack<int> GetABC()
        {
            Stack<int> UI = new Stack<int>();

            Console.WriteLine("Enter A");
            UI.Push(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter B");
            UI.Push(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter C");
            UI.Push(Convert.ToInt32(Console.ReadLine()));

            return UI;
        }

        public static Double GetFactor(bool first)
        {
            if (first == true)
            {
                Console.WriteLine("Enter your first factor");
            }
            if (first == false)
            {
                Console.WriteLine("Enter your second factor");
            }
            Console.Write("X = ");

            return Formater.SwitchDoubleSign(Convert.ToDouble(Console.ReadLine()));
        }

    }
}