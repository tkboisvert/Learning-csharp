using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TKBoisvert.Calculus
{
    class Factoring
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
            XA = Formater.SwitchDoubleSign(XA);
            double XB = UI.GetFactor("second factor","X");
            XB = Formater.SwitchDoubleSign(XB);

            if (Formater.CheckForDecmal(1m, XA) == true)
            {
                setOfFractionComponentsXA = Formater.FractionParser(Formater.ConvertToFraction(XA));

                answerXA = Convert.ToDouble(setOfFractionComponentsXA[2]);

                answerA = Convert.ToDouble(setOfFractionComponentsXA[1]);

                XAIsDecimal = true;
            }
            else
            {
                answerXA = 1;

                answerA = XA;
            }

            if (Formater.CheckForDecmal(1m, XB) == true)
            {
                setOfFractionComponentsXB = Formater.FractionParser(Formater.ConvertToFraction(XB));

                answerXB = Convert.ToDouble(setOfFractionComponentsXB[2]);

                answerB = Convert.ToDouble(setOfFractionComponentsXB[1]);

                XBIsDecimal = true;
            }
            else
            {
                answerXB = 1;

                answerB = XB;
            }

            FinalNumbers = Formater.GetFactorsFromDecimals(answerXA, answerA, answerXB, answerB);

            FinalNumbers[0] = Formater.AddTheProperSign(Convert.ToDouble(FinalNumbers[0]));
            FinalNumbers[1] = Formater.AddTheProperSign(Convert.ToDouble(FinalNumbers[1]));
            FinalNumbers[2] = Formater.AddTheProperSign(Convert.ToDouble(FinalNumbers[2]));

            Text.ResultForFactor(FinalNumbers, XAIsDecimal, XBIsDecimal);

            Console.ReadKey();
        }
    }
}
