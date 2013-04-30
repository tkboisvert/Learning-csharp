using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quadratic_Formula
{
    class Program
    {
        static void Main(string[] args)
        {
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

                        var answerForAddition = (-b + squareRoot) / (2 * a);
                        var answerForSubtraction = (-b - squareRoot) / (2 * a);

                        Console.Clear();
                        Console.WriteLine("X = {0}", answerForAddition);
                        Console.WriteLine("X = {0}", answerForSubtraction);

                        if (Formater.CheckForDecmal(answerForAddition) == true)
                        {
                            string additionAnswer = Formater.ConvertToFraction(Convert.ToDecimal(answerForAddition));
                            string[] setOfFractionComponents = 
                        }

                        Console.WriteLine("Your factors are (X {0}) and (X {1})", Formater.AddTheProperSign(Convert.ToInt32(Formater.AddTheProperSign(Convert.ToInt32(answerForAddition),true)),false), Formater.AddTheProperSign(Convert.ToInt32(Formater.AddTheProperSign(Convert.ToInt32(answerForSubtraction),true)),false));
                        Console.ReadLine();
                    }
                }
                if (chooseWhatToDo == "2")
                {
                    Console.Clear();
                    int X1 = UI.GetFactor(true);
                    int X2 = UI.GetFactor(false);
                    string B = Formater.AddTheProperSign(X1 + X2, false);
                    string C = Formater.AddTheProperSign(X1 * X2, false);
                    Console.WriteLine("X^2 {0} {1}", B, C);
                    Console.Read();
                }
            }
        }
    }
}
