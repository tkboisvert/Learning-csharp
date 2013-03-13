using System;

namespace Calculator
{
    internal class Calculator
    {
        private readonly StringToCalculatorOperatorConverter stringToOperatorConverter;
        private readonly CalcOperatorFactory calcOperatorFactory;

        public Calculator(StringToCalculatorOperatorConverter stringToOperatorConverter, CalcOperatorFactory calcOperatorFactory)
        {
            this.stringToOperatorConverter = stringToOperatorConverter;
            this.calcOperatorFactory = calcOperatorFactory;
        }

        public int Calculate(string firstNumber, string calcOperator, string secondNumber)
        {
            return Calculate(Convert.ToInt32(firstNumber), stringToOperatorConverter.Convert(calcOperator), Convert.ToInt32(secondNumber));
        }

        public int Calculate(int firstNumber, CalcOperation calcOperation, int secondNumber)
        {
            CalcOperator op = calcOperatorFactory.CreateOperator(calcOperation);

            return op.Calculate(firstNumber, secondNumber);
        }
    }
}