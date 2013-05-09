using System;
using System.Collections.Generic;

namespace TKBoisvert.Calculus
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

            Stack<double> uI = new Stack<double>(UI.GetABC());

            double a = uI.Pop();
            double b = uI.Pop();
            double c = uI.Pop();

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

                if (Formatter.CheckForDecmal(1m, answerForAddition) == true)
                {
                    string additionAnswer = Formatter.ConvertToFraction(answerForAddition);

                    setOfFractionComponentsAddition = Formatter.FractionParser(additionAnswer);

                    additionIsDecimal = true;
                }

                if (Formatter.CheckForDecmal(1m, answerForSubtraction) == true)
                {
                    string subtractionAnswer = Formatter.ConvertToFraction(answerForSubtraction);

                    setOfFractionComponentsSubtraction = Formatter.FractionParser(subtractionAnswer);

                    subtractionIsDecimal = true;
                }

                Console.Clear();
                Text.ResultForQF(additionIsDecimal, subtractionIsDecimal, setOfFractionComponentsAddition, setOfFractionComponentsSubtraction, Convert.ToInt32(answerForAddition), Convert.ToInt32(answerForSubtraction));
                Text.xEquals(answerForAddition);
                Text.xEquals(answerForSubtraction);
                Console.ReadKey();
            }
        }
    }
}