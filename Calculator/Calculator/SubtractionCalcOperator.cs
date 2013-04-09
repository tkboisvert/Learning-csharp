namespace Calculator
{
    class SubtractionCalcOperator : CalcOperator
    {
        public override int Calculate(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}