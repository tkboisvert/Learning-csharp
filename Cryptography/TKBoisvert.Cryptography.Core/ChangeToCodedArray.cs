using System;
using System.Text;
using System.Collections.Generic;

namespace TKBoisvert.Cryptography.Core
{
    public class Change
    {
        public int[] ToCodedArray(string stringOfThreeDightNumbers)
        {
            stringOfThreeDightNumbers = Determine.IsDivisibleByFour(stringOfThreeDightNumbers);

            int[] arrayOfInts = new int[stringOfThreeDightNumbers.Length / 4];

            StringBuilder stringBuilder = new StringBuilder();

            int i = 0;

            bool keepsSpacesInCheck = false;

            foreach (char c in stringOfThreeDightNumbers)
            {
                if (char.IsDigit(c))
                {
                    stringBuilder.Append(c);
                    keepsSpacesInCheck = false;
                }
                if (char.IsWhiteSpace(c) && keepsSpacesInCheck == false)
                {
                    arrayOfInts[i] = Convert.ToInt32(stringBuilder.ToString());
                    stringBuilder.Remove(0, stringBuilder.Length);
                    i++;
                    keepsSpacesInCheck = true;
                }
            }

            return arrayOfInts;
        }

        public static string ChangeToFormattedStringForConversion(char[] charArray)
        {
            StringBuilder stringBuilder = new StringBuilder();

            Queue<char> theLastCharacter = new Queue<char>(); theLastCharacter.Enqueue('0');

            foreach (char c in charArray)
            {
                if (c == '/' && theLastCharacter.Peek() == ' ') { stringBuilder.Remove(stringBuilder.Length - 1, 1); break; }
                else if (c == '/') { break; }
                else
                {
                    theLastCharacter.Enqueue(c);
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString();
        }
    }
}