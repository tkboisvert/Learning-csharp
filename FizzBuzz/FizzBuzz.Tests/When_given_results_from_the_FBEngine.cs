using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using System;
namespace FizzBuzz.Tests
{
    [TestFixture]
    public class When_given_results_from_the_FBEngine
    {
        [Test]
        public void should_return_a_formatted_string()
        {
            var fizzBuzzDataFormatter = new FizzBuzzDataFormatter();

            string result = fizzBuzzDataFormatter.Format(new[] {"1", "2", "fizz"});

            result.Should().Be("1 2 fizz");
        }

        [Test]
        public void Should_handle_empty_results()
        {
            var fizzBuzzDataFormatter = new FizzBuzzDataFormatter();

            string result = fizzBuzzDataFormatter.Format(Enumerable.Empty<string>());

            result.Should().BeEmpty();
        }
    }
}