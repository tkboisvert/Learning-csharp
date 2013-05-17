using System;
using System.Text;

namespace TKBoisvert.Cryptography.Core
{
    public class ProgramForEncoding
    {
        public static void Encode(char[] toBeEncoded)
        {

            Scrambler scrambler = new Scrambler();

            AstheticTextAndPieces ATaP = new AstheticTextAndPieces();

            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in toBeEncoded)
            {
                if (c == '/') { stringBuilder.Remove(stringBuilder.Length - 1, 1); break; }
                else { stringBuilder.Append(c); }
            }

            string phraseToBeEncoded = stringBuilder.ToString();

            string codePhrase = ATaP.GetCodeWord();

            int[] arrayOfscrambledCode = scrambler.Scramble(phraseToBeEncoded, codePhrase);

            foreach (int i in arrayOfscrambledCode)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}