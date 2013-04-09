using Calculator.Tests.MultiplicationFixtures;
using CalculatorApp;
using NUnit.Framework;


namespace Calculator.Tests.CalcOperatorFactoryFixtures
{
    [TestFixture]
    class when_using_the_multiplication_Symbol
    {
        [Test]
        public void Should_reurn_a_multiply()
        {
            CalcOperatorFactory calcOperatorFactory = new CalcOperatorFactory();

            CalcOperator result = calcOperatorFactory.CreateOperator(CalcOperation.Multiply);

            Assert.IsInstanceOf<Multiplicator>(result);
        }


    }
}
