using System;

namespace TKBoisvert.Calculus
{
    internal class Formater
    {
        public static string AddTheProperSign(Double intInQuestion)
        {
            if (intInQuestion <= Convert.ToDouble(-1))
            {
                return Convert.ToString(intInQuestion);
            }
            else
            {
                return ("+ " + Convert.ToString(intInQuestion));
            }
        }

        public static int SwitchSign(int intInQuestion)
        {
            return -1 * intInQuestion;
        }

        public static Double SwitchDoubleSign(Double intInQuestion)
        {
            return -1 * intInQuestion;
        }

        public static string ConvertToFraction(double dValue)
        {
            string frac = String.Empty;

            try
            {
                if (dValue > 2147483647 && dValue < 1.0 / 2147483647)
                    frac = "not possible";
                if (dValue % 1 == 0)	// if whole number
                    frac = dValue.ToString();
                else
                {
                    double dTemp = dValue;
                    int iMultiple = 1;
                    string strTemp = dValue.ToString();
                    int i = 0;
                    while (strTemp[i] != '.')
                        i++;
                    int iDigitsAfterDecimal = strTemp.Length - i - 1;
                    while (dTemp * 10 < 2147483647 && iMultiple * 10 < 2147483647 && iDigitsAfterDecimal > 0)
                    {
                        dTemp *= 10;
                        iMultiple *= 10;
                        iDigitsAfterDecimal--;
                    }
                    int temp1 = (int)Math.Round(dTemp);//numerator
                    int temp2 = iMultiple;//denominator
                    frac = ReduceFraction(temp1, temp2);
                }
                return frac;
            }
            catch (Exception)
            {
                return frac = "oops";
            }
        }

        public static string ReduceFraction(int Numerator, int Denominator)
        {
            try
            {
                if (Numerator == 0)
                {
                    Denominator = 1;
                    return Numerator.ToString() + "/" + Denominator.ToString();
                }

                int iGCD = GCD(Numerator, Denominator);
                Numerator /= iGCD;
                Denominator /= iGCD;

                if (Denominator < 0)	// if -ve sign in denominator
                {
                    //pass -ve sign to numerator
                    Numerator *= -1;
                    Denominator *= -1;
                }
                string temp1 = Numerator.ToString();
                string temp2 = Denominator.ToString();
                string frac = temp1 + "/" + temp2;
                return frac;
            }
            catch (Exception)
            {
                return "Cannot reduce Fraction";
            }
        }

        private static int GCD(int iNo1, int iNo2)
        {
            // take absolute values
            if (iNo1 < 0) iNo1 = -iNo1;
            if (iNo2 < 0) iNo2 = -iNo2;

            do
            {
                if (iNo1 < iNo2)
                {
                    int tmp = iNo1; // swap the two operands
                    iNo1 = iNo2;
                    iNo2 = tmp;
                }
                iNo1 = iNo1 % iNo2;
            } while (iNo1 != 0);
            return iNo2;
        }

        public static bool CheckForDecmal(decimal deciInQuestion, double doublInQuestion)
        {
            string intString = Convert.ToString(deciInQuestion);
            foreach (char c in intString)
            {
                if (c == '.')
                {
                    return true;
                }
            }
            intString = Convert.ToString(doublInQuestion);
            foreach (char c in intString)
            {
                if (c == '.')
                {
                    return true;
                }
            }
            return false;
        }

        public static string[] FractionParser(string fraction)
        {
            string[] fractionParts = new string[3];

            int i = 0;

            bool wholeNumberIncluded = true;

            foreach (char c in fraction)
            {
                if (char.IsWhiteSpace(c) || c == '/')
                {
                    i++;
                }
                if (c == '/' && fractionParts[1] == null)
                {
                    wholeNumberIncluded = false;
                }
                if (char.IsDigit(c))
                {
                    fractionParts[i] += c;
                }
            }

            if (wholeNumberIncluded == false)
            {
                fractionParts = Array.ShiftStringArrayUp(fractionParts);
            }

            else
            {
                fractionParts = Array.ConvertToImproperFraction(fractionParts);
            }

            return fractionParts;
        }

        public static string[] GetFactorsFromDecimals(Double XA, Double A, Double XB, Double B)
        {
            string[] finalNumber = new string[3];
            finalNumber[0] = Convert.ToString(XA * XB);
            finalNumber[1] = Convert.ToString((XA * B) + (XB * A));
            finalNumber[2] = Convert.ToString(B * A);
            return finalNumber;
        }
    }
}