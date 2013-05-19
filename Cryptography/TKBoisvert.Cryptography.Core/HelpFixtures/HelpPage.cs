using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TKBoisvert.Cryptography.Core.HelpFixtures
{
    public class HelpPage
    {
        public static void Explaination()
        {
            AstheticTextAndPieces ATaP = new AstheticTextAndPieces();

            ListFlags();

            ATaP.TellSomethingToTheUser(false, null, "Format:", null);
            ATaP.TellSomethingToTheUser(false, "[String to be coded] [/flag]", null, "Press any key to continue. . .");

            Console.ReadKey();
        }

        public static void ListFlags()
        {
            AstheticTextAndPieces ATaP = new AstheticTextAndPieces();

            ATaP.TellSomethingToTheUser(true, "Flags avalible", "null", null);

            foreach (string fD in FlagsAndTheirDefinitions(Flags(), Definitions()))
            {
                Console.WriteLine(fD);
            }
        }

        private static string[] Flags()
        {
            return new string[] { "t", "?" };
        }

        private static string[] Definitions()
        {
            return new string[] { "TKC", "Help" };
        }

        private static string[] FlagsAndTheirDefinitions(string[] flags, string[] definitions)
        {
            string[] stringArray = new string[flags.Length];

            if (Determine.IfTwoStringArraysAreTheSameLength(flags, definitions) == true)
            {
                int i = 0;

                do
                {
                    stringArray[i] = "/" + flags[i] + " " + definitions[i];
                    i++;

                } while (i < flags.Length);

                return stringArray;
            }

            throw new NotSupportedException();
            
        }
    }
}
