using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TKBoisvert.Cryptography.Encode
{
    class Program
    {
        static void Main(string[] args)
        {


            AstheticTextAndPieces ATaP = new AstheticTextAndPieces();

            Scrambler scrambler = new Scrambler();

            string phraseToBeCoded = ATaP.GetSomethingFromTheUser("What do you want to encode", "null", "null");

            string codePhrase = ATaP.GetCodeWord();

            int[] arrayOfscrambledCode = scrambler.Scramble(phraseToBeCoded, codePhrase);

            foreach (int i in arrayOfscrambledCode)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();


        }
    }
}
