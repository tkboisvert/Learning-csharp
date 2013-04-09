using CalculatorApp;
using NUnit.Framework;



namespace Calculator.Tests.MultiplicationFixtures
{
    [TestFixture]
    class When_multiplying_numbers
    {
        [Test]
        public void Should_return_a_multiplied_value()
        {
            Multiplicator multiplicator = new Multiplicator();

            int result = multiplicator.Calculate(2, 2);

            Assert.AreEqual(4, result);
        }
        [Test]
        public void Should_return_a_multiplied_value2()
        {
            Multiplicator multiplicator = new Multiplicator();

            int result = multiplicator.Calculate(3, 2);

            Assert.AreEqual(6, result);
        }

    }
}
