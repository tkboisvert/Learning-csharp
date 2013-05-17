using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TKBoisvert.Cryptography.Core;
using FluentAssertions;
using NUnit.Framework;

namespace TKBoisvert.Cryptography.EncodingTests.EncodingFixtures
{
    [TestFixture]
    class When_a_string_is_passed_in_
    {
        [Test]
        public void should_scramble_it_with_a_specified_string()
        {
            var scrambler = new Scrambler();

            int[] scrambledNumber = scrambler.Scramble("abc", "def"); //string to be scrambled, scrambler string

            int[] whatTheArrayShouldBe = new int[]{ 197, 199, 201 };

            Assert.AreEqual(whatTheArrayShouldBe, scrambledNumber);
        }
    }
}
