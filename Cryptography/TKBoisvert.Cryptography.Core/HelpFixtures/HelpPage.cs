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
            UserInteractions ATaP = new UserInteractions();

            ListFlags();

            ATaP.TellSomethingToTheUser(false, new string[]{null, "Format:", null});
            ATaP.TellSomethingToTheUser(false, new string[]{"[String to be coded] [/flag]", null, "Press any key to continue. . ."});

            Console.ReadKey();
        }

        public static void ListFlags()
        {
            UserInteractions ATaP = new UserInteractions();

            ATaP.TellSomethingToTheUser(true, new string[]{"Flags avalible", "null", null});

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

            throw new Exception();
        }
    }
}
