using NUnit.Framework;
using TKBoisvert.Cryptography.Core;

namespace TKBoisvert.Cryptography.EncodingTests.EncodingFixtures
{
    [TestFixture]
    internal class When_a_string_is_passed_in_
    {
        [Test]
        public void should_scramble_it_with_a_specified_string()
        {
            var scrambler = new Scrambler();

            int[] scrambledNumber = scrambler.Scramble("abc", "def"); //string to be scrambled, scrambler string

            int[] whatTheArrayShouldBe = new int[] { 197, 199, 201 };

            Assert.AreEqual(whatTheArrayShouldBe, scrambledNumber);
        }
    }
}