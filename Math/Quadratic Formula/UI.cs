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

                Text.menu();
                
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

        public static double GetFactor(string WhichOne, string NullOrX)
        {
            Console.WriteLine("Enter the {0}", WhichOne);

            Console.Write("{0} ", NullOrX);

            string x = Console.ReadLine();

            CheckIsNumber(x);
            
            return Formatter.ChangeFractionsToDecimal_StillReturnsDouble_(x);
        }

        public static void CheckIsNumber(string stringInQuestion)
        {
            foreach (char c in stringInQuestion)
            {
                if (char.IsLetter(c) || char.IsWhiteSpace(c))
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}