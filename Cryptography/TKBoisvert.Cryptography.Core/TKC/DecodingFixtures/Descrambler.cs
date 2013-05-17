using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TKBoisvert.Cryptography.Core
{
    public class Descrambler
    {
        public int SubtractKey(int first, int second)
        {
            return first -= second;

        }

        public int[] Descramble(int[] scrambledText, string codePhrase)
        {
            Scrambler scrambler = new Scrambler();

            int[] arrayOfNumbersThatRepresentsTheCodePhrase = scrambler.ArrayOfASCIIValues(codePhrase);

            int[] DecodedText = new int[scrambledText.Length];

            int x = 0;

            int y = 0;

            foreach (int i in scrambledText)
            {
                if (x == arrayOfNumbersThatRepresentsTheCodePhrase.Length)
                {
                    x = 0;
                }
                DecodedText[y] = SubtractKey(i, arrayOfNumbersThatRepresentsTheCodePhrase[x]);
                x++;
                y++;
            }

            return DecodedText;
        }

        public string ASCIIToString(int i)
        {
            char character = (char)i;
            return (character.ToString());
        }

        public string ArrayOfASCIIToString(int[] arrayOfASCIIValues)
        {
            string text = "";

            foreach (int i in arrayOfASCIIValues)
            {
                text += ASCIIToString(i);
            }

            return text;
        }
    }
}
