using System;

namespace TKBoisvert.Cryptography.Core
{
    public class Scrambler
    {
        public int ChangeToUtf8Value(char c)
        {
            foreach (byte b in System.Text.Encoding.UTF8.GetBytes(new char[]{c}))
            {
                return Convert.ToInt32(b);
            }
            throw new ArgumentOutOfRangeException();
        }

        public int[] ArrayOfUtf8Values(string StringToBeArrayed)
        {
            int[] ArrayOfValues = new int[StringToBeArrayed.Length];

            int i = 0;

            foreach (char c in StringToBeArrayed)
            {
                ArrayOfValues[i] = ChangeToUtf8Value(c);
                i++;
            }

            return ArrayOfValues;
        }

        public int[] Scramble(string toBeScrambled, string scramblingWord)
        {
            int[] arrayOfNumbersThatRepresentsTheStringToBeScrambled = ArrayOfUtf8Values(toBeScrambled);
            int[] arrayOfNumbersThatRepresentsTheScramblingWord = ArrayOfUtf8Values(scramblingWord);


            return Encode(arrayOfNumbersThatRepresentsTheScramblingWord, arrayOfNumbersThatRepresentsTheStringToBeScrambled);
        }

        private int[] Encode(int[] scramblingWord, int[] phraseToBeEncoded)
        {
            int[] encodedPhrase = new int[phraseToBeEncoded.Length];

            int x = 0;
            int y = 0;

            foreach (int i in phraseToBeEncoded)
            {
                if (x == scramblingWord.Length) { x = 0; }

                encodedPhrase[y] = AddTogether(i, scramblingWord[x]);
                x++;
                y++;
            }

            return encodedPhrase;

        }

        public int AddTogether(int first, int second)
        {
            return first += second;
        }
    }
}