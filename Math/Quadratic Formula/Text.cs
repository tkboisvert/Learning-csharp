using System;

namespace TKBoisvert.Calculus
{
    internal class Text
    {
        public static void ResultForQF(bool additionIsDecimal,
            bool subtractionIsDecimal,
            string[] setOfFractionComponentsAddition,
            string[] setOfFractionComponentsSubtraction,
            int answerForAddition,
            int answerForSubtraction)
        {
            if (additionIsDecimal == true && subtractionIsDecimal == true)
            {
                Console.WriteLine("Your factors are ({0}X {1}) and ({2}X {3})", 
                    setOfFractionComponentsAddition[2], 
                    Formatter.AddTheProperSign(Formatter.SwitchDoubleSign(Convert.ToDouble(setOfFractionComponentsAddition[1]))),
                    setOfFractionComponentsSubtraction[2], 
                    Formatter.AddTheProperSign(Formatter.SwitchDoubleSign(Convert.ToDouble(setOfFractionComponentsSubtraction[1]))));
            }
            else if (additionIsDecimal == true && subtractionIsDecimal == false)
            {
                Console.WriteLine("Your factors are ({0}X {1}) and (X {2})", 
                    setOfFractionComponentsAddition[2],
                    Formatter.AddTheProperSign(Formatter.SwitchDoubleSign(Convert.ToDouble(setOfFractionComponentsAddition[1]))),
                    Formatter.AddTheProperSign(Formatter.SwitchDoubleSign(Convert.ToDouble(answerForSubtraction))));
            }
            else if (additionIsDecimal == false && subtractionIsDecimal == true)
            {
                Console.WriteLine("Your factors are (X {0}) and ({1}X {2})",
                    Formatter.AddTheProperSign(Formatter.SwitchDoubleSign(Convert.ToDouble(answerForAddition))), 
                    setOfFractionComponentsSubtraction[2], 
                    Formatter.AddTheProperSign(Formatter.SwitchDoubleSign(Convert.ToDouble(setOfFractionComponentsSubtraction[1]))));
            }
            else
            {
                Console.WriteLine("Your factors are (X {0}) and (X {1})", 
                    Formatter.AddTheProperSign(Formatter.SwitchDoubleSign(Convert.ToDouble(answerForAddition))), 
                    Formatter.AddTheProperSign(Formatter.SwitchDoubleSign(Convert.ToDouble(answerForSubtraction))));
            }
        }

        public static void ResultForFactor(string[] FinalNumbers, bool XAIsDecimal, bool XBIsDecimal)
        {
            if ((XAIsDecimal == true && XBIsDecimal == true) || (XAIsDecimal == true && XBIsDecimal == false) || (XAIsDecimal == false && XBIsDecimal == true))
            {
                Console.WriteLine("{0}X^2 {1}X {2}", FinalNumbers[0], FinalNumbers[1], FinalNumbers[2]);
            }
            else
            {
                Console.WriteLine("X^2 {0}X {1}", FinalNumbers[1], FinalNumbers[2]);
            }
        }

        public static void notDefinableAnswer(double squareRootContents, double b, double c)
        {
            Console.Clear();
            Console.WriteLine("               -{0} {1} {2}({3})", b, '±', '√', squareRootContents);
            Console.WriteLine("The answer is: ----------");
            Console.WriteLine("                   {0}", 2 * c);
            Console.ReadKey();
        }

        public static void sumIs(double answer, string FactorYoureRepresenting)
        {
            Console.WriteLine("{0} = {1}",FactorYoureRepresenting, answer);
        }

        public static void menu()
        {

            Console.WriteLine("╓──────────────────────────────────╖");
            Console.WriteLine("║Press. . .                        ║");
            Console.WriteLine("╟──────────────────────────────────╢");
            Console.WriteLine("║1 for factoring                   ║");
            Console.WriteLine("║2 for checking factors            ║");
            Console.WriteLine("║3 for Addition Sequences & Series ║");
            Console.WriteLine("║4 for Geometric Sequences & Series║");
            Console.WriteLine("╙──────────────────────────────────╜");
        }
    }
}