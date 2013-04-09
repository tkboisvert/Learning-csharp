using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string equationString = Console.ReadLine();

            EquationParser equationParser = new EquationParser(new StringToCalculatorOperatorConverter());

            Equation equation = equationParser.Parse(equationString);

            Calculator.Calculator calc = new Calculator.Calculator(new StringToCalculatorOperatorConverter(), new CalcOperatorFactory());

            int result = calc.Calculate(equation.FirstNumber, equation.Operation, equation.SecondNumber);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }

    internal class EquationParser
    {
        private readonly StringToCalculatorOperatorConverter calculatorOperatorConverter;

        public EquationParser(StringToCalculatorOperatorConverter calculatorOperatorConverter)
        {
            this.calculatorOperatorConverter = calculatorOperatorConverter;
        }

        public Equation Parse(string equationString)
        {
            bool readOperator = false;

            IList<char> firstNumberCharList = new List<char>();

            IList<char> secondNumberCharList = new List<char>();

            string operation = null;

            foreach (char c in equationString)
            {
                if (char.IsDigit(c))
                {
                    if (! readOperator)
                    {
                        firstNumberCharList.Add(c);
                    }
                    else
                    {
                        secondNumberCharList.Add(c);
                    }
                }
                else
                {
                    operation = c.ToString();
                    readOperator = true;
                }
            }

            int firstNumber = Convert.ToInt32(new string(firstNumberCharList.ToArray()));
            int secondNumber = Convert.ToInt32(new string(secondNumberCharList.ToArray()));

            return new Equation(firstNumber, calculatorOperatorConverter.Convert(operation), secondNumber);
        }
    }

    internal class Equation
    {
        public Equation(int firstNumber, CalcOperation operation, int secondNumber)
        {
            SecondNumber = secondNumber;
            Operation = operation;
            FirstNumber = firstNumber;
        }

        public int FirstNumber { get; private set; }
        public int SecondNumber { get; private set; }
        public CalcOperation Operation { get; private set; }
    }
}
