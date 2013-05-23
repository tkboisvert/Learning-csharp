using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    class When_converting_a_single_number_to_fizz_buzz
    {
        public void Should_convert_1_to_the_string_1()
        {
            var converter = new FizzBuzzNumberConverter();
        }
    }

    internal class FizzBuzzNumberConverter
    {
    }
}