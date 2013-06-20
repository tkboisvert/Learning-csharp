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

            string result = fizzBuzzDataFormatter.Format(new[] {"1", "2", "fizz", "fizz", "buzz", "buzz", "buzz", "fizzbuzz", "lucky"});

            result.Should().Be(
@"1 2 fizz fizz buzz buzz buzz fizzbuzz lucky
fizz: 2
buzz: 3
fizzbuzz: 1
lucky: 1
integer: 2 - because there were 2 numbers that were not altered");
        }

        [Test]
        public void should_return_a_formatted_string_with_three_numbers()
        {
            var fizzBuzzDataFormatter = new FizzBuzzDataFormatter();

            string result = fizzBuzzDataFormatter.Format(new[] { "1", "2", "3" });

            result.Should().Be(
@"1 2 3
fizz: 0
buzz: 0
fizzbuzz: 0
lucky: 0
integer: 3 - because there were 3 numbers that were not altered");
        }

        [Test]
        public void should_return_a_formatted_string_with_one_number()
        {
            var fizzBuzzDataFormatter = new FizzBuzzDataFormatter();

            string result = fizzBuzzDataFormatter.Format(new[] { "1" });

            result.Should().Be(
@"1
fizz: 0
buzz: 0
fizzbuzz: 0
lucky: 0
integer: 1 - because there was 1 number that was not altered");
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