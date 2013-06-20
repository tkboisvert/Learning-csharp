using System;

namespace TKBoisvert.Cryptography.Core
{
    public class ProgramForEncoding
    {
        public static void Encode(string toBeEncoded)
        {

            string codePhrase = new UserInteractions().GetAndVerifyPassPhrase();

            int[] arrayOfscrambledCode = new Scrambler().Scramble(toBeEncoded, codePhrase);

            foreach (int i in arrayOfscrambledCode)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}