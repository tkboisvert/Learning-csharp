using System;

namespace Calculator
{
    internal class StringToCalculatorOperatorConverter
    {
        public CalcOperation Convert(string calcOperation)
        {
            switch (calcOperation)
            {
                case "+":
                    return CalcOperation.Addition;
                    
                case "-":
                    return CalcOperation.Subtraction;
                    
                case "/":
                    return CalcOperation.Divide;

                case "*":
                    return CalcOperation.Multiply;

                default:
                    throw new Exception("Idiot");
            }
        }
    }
}