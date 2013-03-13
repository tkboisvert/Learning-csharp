namespace Calculator
{
    class AdditionCalcOperator : CalcOperator
    {
        public override int Calculate(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}