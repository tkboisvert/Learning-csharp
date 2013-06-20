using System;
using System.Text;
using System.Linq;

namespace TKBoisvert.Calculus.ConsoleApp
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
            string menu = BuildMenu(new[] {
                "factoring", "checking factors", "Addition Sequences & Series", "Geometric Sequences & Series", "Binomial Theorem" });

            Console.Write(menu);
        }

        private static string BuildMenu(string[] menuItems)
        {
            const int minSize = 7;
            int longestMenuItemName = menuItems.OrderByDescending(s => s.Length).First().Length;
            int padSize = minSize + longestMenuItemName;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("╓".PadRight(padSize, '─') + "╖");
            stringBuilder.AppendLine("║Press. . .".PadRight(padSize) + "║");
            stringBuilder.AppendLine("╟".PadRight(padSize, '─') + "╢");

            for (int i = 0; i < menuItems.Length; i++)
            {
                var menuItem = string.Format("║{0} for {1}", i + 1, menuItems[i]);
                stringBuilder.AppendLine(menuItem.PadRight(padSize) + "║");
            }
            stringBuilder.AppendLine("╙".PadRight(padSize, '─') + "╜");

            return stringBuilder.ToString();
        }
    }
}