using System;

namespace TKBoisvert.Cryptography.Encode
{
    public class Scrambler
    {
        public int ChangeToASCIIValue(string s)
        {
            string StringOfNumbers = null;

            foreach (byte b in System.Text.Encoding.UTF8.GetBytes(s.ToCharArray()))
            {
                StringOfNumbers += b.ToString();
            }

            return Convert.ToInt32(StringOfNumbers);
        }

        public int[] ArrayOfASCIIValues(string StringToBeArrayed)
        {
            int[] ArrayOfValues = new int[StringToBeArrayed.Length];

            int i = 0;

            foreach (char c in StringToBeArrayed)
            {
                ArrayOfValues[i] += ChangeToASCIIValue(Convert.ToString(c));
                i++;
            }

            return ArrayOfValues;
        }

        public int[] Scramble(string toBeScrambled, string scramblingWord)
        {
            int[] arrayOfNumbersThatRepresentsTheStringToBeScrambled = ArrayOfASCIIValues(toBeScrambled);
            int[] arrayOfNumbersThatRepresentsTheScramblingWord = ArrayOfASCIIValues(scramblingWord);
            int[] arrayOfNumbersThatRepresentsTheScrambledWord = new int[arrayOfNumbersThatRepresentsTheStringToBeScrambled.Length];

            int x = 0;
            int y = 0;

            foreach (int i in arrayOfNumbersThatRepresentsTheStringToBeScrambled)
            {
                if (x == arrayOfNumbersThatRepresentsTheScramblingWord.Length) { x = 0; }

                arrayOfNumbersThatRepresentsTheScrambledWord[y] = AddTogether(i, arrayOfNumbersThatRepresentsTheScramblingWord[x]);
                x++;
                y++;
            }
            return arrayOfNumbersThatRepresentsTheScrambledWord;
        }

        public int AddTogether(int first, int second)
        {
            return first += second;
        }
    }
}