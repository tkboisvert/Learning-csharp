using System;

namespace TKBoisvert.Cryptography.Core
{
    public class ProgramForEncoding
    {
        public static void Encode(string toBeEncoded)
        {
            Scrambler scrambler = new Scrambler();

            AstheticTextAndPieces ATaP = new AstheticTextAndPieces();

            string codePhrase = ATaP.GetAndVerifyPassPhrase();

            int[] arrayOfscrambledCode = scrambler.Scramble(toBeEncoded, codePhrase);

            foreach (int i in arrayOfscrambledCode)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}