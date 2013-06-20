using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    class When_converting_a_single_number_to_fizz_buzz
    {
        [TestCase(1, "1")]
        [TestCase(3, "fizz")]
        [TestCase(5, "buzz")]
        [TestCase(6, "fizz")]
        [TestCase(10, "buzz")]
        [TestCase(15, "fizzbuzz")]
        [TestCase(30, "fizzbuzz")]
        public void Should_convert_the_inout_to_the_expected_output(int inputValue, string expectedValue)
        {
            var numberToFizzBuzzConverter = new NumberToFizzBuzzConverter();

            numberToFizzBuzzConverter.Convert(inputValue).Should().Be(expectedValue);
        }
    }
}