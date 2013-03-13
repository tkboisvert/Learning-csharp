using CalculatorApp;
using NUnit.Framework;

namespace Calculator.Tests.DivisionFixtures
{
    [TestFixture]
    class When_dividing_numbers
    {
        [Test]
        public void Should_return_a_proper_quotient()
        {

            Divider divider = new Divider();

            int result = divider.Calculate(9, 3);

            Assert.AreEqual(3, result);

        }

    }
}
