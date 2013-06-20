using System;
using System.Collections.Generic;

namespace TKBoisvert.Calculus.ConsoleApp
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

                if (myChoice == "1" || myChoice == "2" || myChoice == "3" || myChoice == "4" || myChoice == "5")
                {
                    Console.Clear();
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

            Console.Write("{0} = ", NullOrX);

            string x = Console.ReadLine();

            if (CheckIsNumber(x) == false)
            {
                Console.Clear();

                return GetFactor(WhichOne, NullOrX);
            }

            return Formatter.ChangeFractionsToDecimal_StillReturnsDouble_(x);
        }

        public static bool CheckIsNumber(string stringInQuestion)
        {
            foreach (char c in stringInQuestion)
            {
                if (char.IsLetter(c) || char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }

        public static string GetStringFactor(string enterThe__WhatYouWant, string WhatYouWant)
        {
            Console.WriteLine("Enter the {0}", enterThe__WhatYouWant);

            Console.Write("{0} = ", WhatYouWant);

            return Console.ReadLine();

        }
    }
}