namespace Calculator
{
    internal class Divider : CalcOperator
    {
        public override int Calculate(int firstNumber, int secondNumber)
        {
            return (firstNumber / secondNumber);
        }
    }
}