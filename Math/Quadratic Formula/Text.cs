﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quadratic_Formula
{
    class Text
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
                Console.WriteLine("Your factors are ({0}X {1}) and ({2}X {3})", setOfFractionComponentsAddition[2], Formater.AddTheProperSign(Formater.SwitchSign(Convert.ToInt32(setOfFractionComponentsAddition[1]))), setOfFractionComponentsSubtraction[2], Formater.AddTheProperSign(Formater.SwitchSign(Convert.ToInt32(setOfFractionComponentsSubtraction[1]))));
            }
            else if (additionIsDecimal == true && subtractionIsDecimal == false)
            {
                Console.WriteLine("Your factors are ({0}X {1}) and (X {2})", setOfFractionComponentsAddition[2], Formater.AddTheProperSign(Formater.SwitchSign(Convert.ToInt32(setOfFractionComponentsAddition[1]))), Formater.AddTheProperSign(Formater.SwitchSign(Convert.ToInt32(answerForSubtraction))));
            }
            else if (additionIsDecimal == false && subtractionIsDecimal == true)
            {
                Console.WriteLine("Your factors are (X {0}) and ({1}X {2})", Formater.AddTheProperSign(Formater.SwitchSign(Convert.ToInt32(answerForAddition))), setOfFractionComponentsSubtraction[2], Formater.AddTheProperSign(Formater.SwitchSign(Convert.ToInt32(setOfFractionComponentsSubtraction[1]))));
            }
            else
            {
                Console.WriteLine("Your factors are (X {0}) and (X {1})", Formater.AddTheProperSign(Formater.SwitchSign(Convert.ToInt32(answerForAddition))), Formater.AddTheProperSign(Formater.SwitchSign(Convert.ToInt32(answerForSubtraction))));
            }
            Console.ReadLine();
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
    }
}
