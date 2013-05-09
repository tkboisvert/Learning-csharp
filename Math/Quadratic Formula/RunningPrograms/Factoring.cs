using System;

namespace TKBoisvert.Calculus
{
    internal class Factoring
    {
        public static void Run()
        {
            string[] setOfFractionComponentsXB = new string[5];

            string[] setOfFractionComponentsXA = new string[5];

            bool XAIsDecimal = false;

            bool XBIsDecimal = false;

            double answerXA = 0;

            double answerA = 0;

            double answerXB = 0;

            double answerB = 0;

            string[] FinalNumbers = new string[3];

            Console.Clear();

            double XA = UI.GetFactor("first factor", "X");
            double XB = UI.GetFactor("second factor", "X");

            if (Formatter.CheckForDecmal(XA) == true)
            {
                setOfFractionComponentsXA = Formatter.FractionParser(Formatter.ConvertToFraction(XA));

                answerXA = Convert.ToDouble(setOfFractionComponentsXA[2]);

                answerA = Convert.ToDouble(setOfFractionComponentsXA[1]);

                XAIsDecimal = true;
            }
            else
            {
                answerXA = 1;

                answerA = XA;
            }

            if (Formatter.CheckForDecmal(XB) == true)
            {
                setOfFractionComponentsXB = Formatter.FractionParser(Formatter.ConvertToFraction(XB));

                answerXB = Convert.ToDouble(setOfFractionComponentsXB[2]);

                answerB = Convert.ToDouble(setOfFractionComponentsXB[1]);

                XBIsDecimal = true;
            }
            else
            {
                answerXB = 1;

                answerB = XB;
            }

            FinalNumbers = Formatter.GetFactorsFromDecimals(answerXA, answerA, answerXB, answerB);

            FinalNumbers = Array.addProperSignToEachString(FinalNumbers);

            Text.ResultForFactor(FinalNumbers, XAIsDecimal, XBIsDecimal);

            Console.ReadKey();
        }
    }
}