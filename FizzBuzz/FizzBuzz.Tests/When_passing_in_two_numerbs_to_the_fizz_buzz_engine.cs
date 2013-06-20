using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    class When_passing_in_two_numerbs_to_the_fizz_buzz_engine
    {
        private FizzBuzzEngine fizzBuzzEngine;

        [SetUp]
        public void SetUp()
        {
            fizzBuzzEngine = new FizzBuzzEngine();
        }
        
        [Test]
        public void Should_rteurn_the_number_one_and_two()
        {
            var result = fizzBuzzEngine.Run(1, 2);

            result.Should().ContainInOrder(new [] { "1", "2" });
        }
    
        [Test]
        public void Should_return_fizz_for_the_number_six()
        {
            var result = fizzBuzzEngine.Run(6, 6);

            result.Should().Contain("fizz");
        }

        [Test]
        public void Should_return_lucky_for_three()
        {
            var result = fizzBuzzEngine.Run(3, 3);

            result.Should().Contain("lucky");
        }

        [Test]
        public void Should_return_buzz_for_the_number_five()
        {
            var result = fizzBuzzEngine.Run(5, 5);

            result.Should().Contain("buzz");
        }

        [Test]
        public void Should_return_the_correct_fizz_buzz_results_between_the_range_1_to_20()
        {
            var result = fizzBuzzEngine.Run(1, 20);

            result.Should().ContainInOrder(
                new object[]
                    {
                        "1", "2", "lucky", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11", "fizz", "lucky", "14",
                        "fizzbuzz", "16", "17", "fizz", "19", "buzz"
                    });
        }
    
    }
}
