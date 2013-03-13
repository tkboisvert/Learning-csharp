using System;

namespace Calculator
{
    internal class CalcOperatorFactory
    {
        public CalcOperator CreateOperator(CalcOperation calcOperation)
        {
            switch (calcOperation)
            {
                case CalcOperation.Addition:
                    return new AdditionCalcOperator();

                case CalcOperation.Subtraction:
                    return new SubtractionCalcOperator();
                    
                case CalcOperation.Multiply:
                    return new Multiplicator();

                default:
                    throw new NotImplementedException("We dont support that yet");
            }
        }
    }
}