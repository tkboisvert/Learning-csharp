using System;
using System.Collections.Generic;

namespace TKBoisvert.Calculus.ConsoleApp
{
    internal class QuadraticFormula
    {
        public static void Run()
        {
            string[] setOfFractionComponentsSubtraction = new string[5];

            string[] setOfFractionComponentsAddition = new string[5];

            bool additionIsDecimal = false;

            bool subtractionIsDecimal = false;

            Console.Clear();


            double a = UI.GetFactor("factor (A)", "A = ");
            double b = UI.GetFactor("factor (B)", "B = ");
            double c = UI.GetFactor("factor (C)", "C = ");

            double squareRootContents = Equations.contentsOfSquareRootForQF(a, b, c);

            if (squareRootContents <= -1)
            {
                Text.notDefinableAnswer(squareRootContents, b, c);
            }

            else
            {
                double squareRoot = Math.Sqrt(squareRootContents);

                double answerForAddition = Equations.positiveResultForQF(squareRoot, b, a);
                double answerForSubtraction = Equations.negativeResultForQF(squareRoot, b, a);

                if (Formatter.CheckForDecmal(answerForAddition) == true)
                {
                    string additionAnswer = Formatter.ConvertToFraction(answerForAddition);

                    setOfFractionComponentsAddition = Formatter.FractionParser(additionAnswer);

                    additionIsDecimal = true;
                }

                if (Formatter.CheckForDecmal(answerForSubtraction) == true)
                {
                    string subtractionAnswer = Formatter.ConvertToFraction(answerForSubtraction);

                    setOfFractionComponentsSubtraction = Formatter.FractionParser(subtractionAnswer);

                    subtractionIsDecimal = true;
                }

                Console.Clear();
                Text.ResultForQF(additionIsDecimal, subtractionIsDecimal, setOfFractionComponentsAddition, setOfFractionComponentsSubtraction, Convert.ToInt32(answerForAddition), Convert.ToInt32(answerForSubtraction));
                Text.sumIs(answerForAddition, "X");
                Text.sumIs(answerForSubtraction, "X");
                Console.ReadKey();
            }
        }
    }
}