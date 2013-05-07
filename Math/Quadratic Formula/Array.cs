using System;

namespace Quadratic_Formula
{
    internal class Array
    {
        public static string[] ShiftStringArrayUp(string[] stringsToShift)
        {
            int lengthOfArray = (stringsToShift.Length - 1);
            foreach (string s in stringsToShift)
            {
                if (lengthOfArray == 0)
                {
                    stringsToShift[lengthOfArray] = null;
                    break;
                }
                else
                {
                    stringsToShift[lengthOfArray] = stringsToShift[--lengthOfArray];
                }
            }
            return stringsToShift;
        }

        public static string[] ConvertToImproperFraction(string[] stringsToConvert)
        {
            int[] intArray = new int[3];
            intArray[0] = Convert.ToInt32(stringsToConvert[0]);
            intArray[1] = Convert.ToInt32(stringsToConvert[1]);
            intArray[2] = Convert.ToInt32(stringsToConvert[2]);

            intArray[1] += (intArray[0] * intArray[2]);

            stringsToConvert = Array.ShiftStringArrayUp(stringsToConvert);

            return stringsToConvert;
        }
    }
}