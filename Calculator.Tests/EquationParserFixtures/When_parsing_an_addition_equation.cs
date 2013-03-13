using CalculatorApp;
using NUnit.Framework;

namespace Calculator.Tests.EquationParserFixtures
{
    [TestFixture]
    public class When_parsing_an_addition_equation
    {
        private EquationParser equationParser;
        private Equation result;

        [SetUp]
        public void SetUp()
        {
            equationParser = new EquationParser(new StringToCalculatorOperatorConverter());

            result = equationParser.Parse("1+2");
        }

        [Test]
        public void Should_return_the_first_number_in_the_equation()
        {
            Assert.AreEqual(1, result.FirstNumber);
        }

        [Test]
        public void Should_return_the_second_number_in_the_equation()
        {
            Assert.AreEqual(2, result.SecondNumber);
        }

        [Test]
        public void Should_return_a_plus_sign()
        {
            Assert.AreEqual(CalcOperation.Addition, result.Operation);
        }
    }
}