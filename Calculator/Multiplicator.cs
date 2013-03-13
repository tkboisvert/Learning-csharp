namespace Calculator
{
    internal class Multiplicator : CalcOperator
    {
        public override int Calculate(int firstNumber, int secondNumber)
        {
            return(firstNumber*secondNumber);
        }
    }
}