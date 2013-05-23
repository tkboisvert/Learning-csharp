using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    class WhenPassingInTwoNumerbsToTheFizzBuzzEngine
    {
        [Test]
        public void Should_return_the_numer_one_as_a_string()
        {
            var fizzBuzzEngine = new FizzBuzzEngine();

            var result = fizzBuzzEngine.Run(1, 1);

            result.Should().Contain("1");
        }

        [Test]
        public void Should_rteurn_the_number_one_and_two()
        {
            var fizzBuzzEngine = new FizzBuzzEngine();

            var result = fizzBuzzEngine.Run(1, 2);

            result.Should().ContainInOrder(new [] { "1", "2" });
        }
    
        [Test]
        public void Should_return_fizz_for_the_number_three()
        {
            var fizzBuzzEngine = new FizzBuzzEngine();

            var result = fizzBuzzEngine.Run(3, 3);

            result.Should().Contain("fizz");
        }
    
    }
}
