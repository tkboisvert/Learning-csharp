using System;

namespace TKBoisvert.Calculus
{
    internal class Array
    {
        public static string[] ShiftStringArrayUp(string[] stringsToShift)
        {
            string[] strings = new string[stringsToShift.Length];

            int lengthOfArray = (strings.Length - 1);
            foreach (string s in strings)
            {
                if (lengthOfArray == 0)
                {
                    strings[lengthOfArray] = null;
                    break;
                }
                else
                {
                    strings[lengthOfArray] = strings[--lengthOfArray];
                }
            }
            return strings;
        }

        public static string[] ConvertToImproperFraction(string[] stringsToConvert)
        {
            double[] doubleArray = new double[3];

            doubleArray = Array.ConvertStringArrayToDoubleArray(stringsToConvert);

            doubleArray[1] += (doubleArray[0] * doubleArray[2]);

            stringsToConvert = Array.ConvertDoubleArrayToStringArray(doubleArray);

            stringsToConvert = Array.ShiftStringArrayUp(stringsToConvert);

            return stringsToConvert;
        }

        public static double[] ConvertStringArrayToDoubleArray(string[] stringsToConvert)
        {
            int i = 0;
            double[] doubleArray = new double[stringsToConvert.Length];

            foreach (string s in stringsToConvert)
            {
                doubleArray[i] = Convert.ToDouble(s);
                i++;
            }

            return doubleArray;
        }

        public static string[] ConvertDoubleArrayToStringArray(double[] doublesToConvert)
        {
            int i = 0;
            string[] stringArray = new string[doublesToConvert.Length];

            foreach (double d in doublesToConvert)
            {
                stringArray[i] = Convert.ToString(d);
                i++;
            }

            return stringArray;
        }

        public static string[] switchAllSignsInDoubleArray(double[] doubleArray)
        {
            int i = 0;

            string[] stringArray = new string[doubleArray.Length];

            foreach (double d in doubleArray)
            {
                stringArray[i] = Convert.ToString(Formatter.SwitchDoubleSign(d));
                i++;
            }

            return stringArray;
        }

        public static string[] addProperSignToEachString(string[] stringsToSwitch)
        {
            int i = 0;
            foreach (string s in stringsToSwitch)
            {
                stringsToSwitch[i] = Formatter.AddTheProperSign(Convert.ToDouble(s));
                i++;
            }
            return stringsToSwitch;
        }
    }
}