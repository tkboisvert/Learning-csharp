using System;
using System.Collections.Generic;

namespace Quadratic_Formula
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string subtractionAnswer = null;

            string additionAnswer = null;

            string[] setOfFractionComponentsSubtraction = new string[5];

            string[] setOfFractionComponentsAddition = new string[5];

            bool additionIsDecimal = false;

            bool subtractionIsDecimal = false;

            //--------------------------------

            string[] setOfXAFractionComponents = new string[3];

            double answerXA = 0;

            double answerA = 0;

            bool XAIsDecimal = false;

            string[] setOfXBFractionComponents = new string[3];

            double answerXB = 0;

            double answerB = 0;

            bool XBIsDecimal = false;

            string[] FinalNumbers = new string[3];

            while (true)
            {
                string chooseWhatToDo = UI.GetSelection();

                if (chooseWhatToDo == "1")
                {
                    Console.Clear();

                    Stack<int> uI = new Stack<int>(UI.GetABC());

                    int a = uI.Pop();
                    int b = uI.Pop();
                    int c = uI.Pop();

                    int squareRootContents = ((b * b) - (4 * a * c));

                    if (squareRootContents <= -1)
                    {
                        Console.Clear();
                        Console.WriteLine("               -{0} {1} {2}({3})", b, '±', '√', squareRootContents);
                        Console.WriteLine("The answer is: ----------");
                        Console.WriteLine("                   {0}", 2 * c);
                        Console.Read();
                    }
                    else
                    {
                        double squareRoot = Math.Sqrt(squareRootContents);

                        double answerForAddition = (-b + squareRoot) / (2 * a);
                        double answerForSubtraction = (-b - squareRoot) / (2 * a);

                        Console.Clear();
                        Console.WriteLine("X = {0}", answerForAddition);
                        Console.WriteLine("X = {0}", answerForSubtraction);

                        if (Formater.CheckForDecmal(1m, answerForAddition) == true)
                        {
                            additionAnswer = Formater.ConvertToFraction(answerForAddition);

                            setOfFractionComponentsAddition = Formater.FractionParser(additionAnswer);

                            additionIsDecimal = true;
                        }

                        if (Formater.CheckForDecmal(1m, answerForSubtraction) == true)
                        {
                            subtractionAnswer = Formater.ConvertToFraction(answerForSubtraction);

                            setOfFractionComponentsSubtraction = Formater.FractionParser(subtractionAnswer);

                            subtractionIsDecimal = true;
                        }

                        Text.ResultForQF(additionIsDecimal, subtractionIsDecimal, setOfFractionComponentsAddition, setOfFractionComponentsSubtraction, Convert.ToInt32(answerForAddition), Convert.ToInt32(answerForSubtraction));
                    }
                }

                if (chooseWhatToDo == "2")
                {

                    Console.Clear();

                    double XA = UI.GetFactor(true);
                    double XB = UI.GetFactor(false);

                    if (Formater.CheckForDecmal(1m, XA) == true)
                    {
                        setOfXAFractionComponents = Formater.FractionParser(Formater.ConvertToFraction(XA));

                        answerXA = Convert.ToDouble(setOfXAFractionComponents[2]);

                        answerA = Convert.ToDouble(setOfXAFractionComponents[1]);

                        XAIsDecimal = true;
                    }
                    else
                    {
                        answerXA = 1;

                        answerA = XA;
                    }

                    if (Formater.CheckForDecmal(1m, XB) == true)
                    {
                        setOfXBFractionComponents = Formater.FractionParser(Formater.ConvertToFraction(XB));

                        answerXB = Convert.ToDouble(setOfXBFractionComponents[2]);

                        answerB = Convert.ToDouble(setOfXBFractionComponents[1]);

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
                    
                    Console.Read();
                }
            }
        }
    }
}