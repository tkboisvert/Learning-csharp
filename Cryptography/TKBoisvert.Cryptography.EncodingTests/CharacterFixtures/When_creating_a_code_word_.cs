using NUnit.Framework;
using TKBoisvert.Cryptography.Core;

namespace TKBoisvert.Cryptography.EncodingTests.CharacterFixtures
{
    [TestFixture]
    internal class When_creating_a_code_word_
    {
        [Test]
        public void should_return_an_array_that_reflects_the_word()
        {
            Scrambler scrambler = new Scrambler();

            int[] intArray = scrambler.ArrayOfASCIIValues("Hello World");

            int[] intArrayTwo = new int[] { 72, 101, 108, 108, 111, 32, 87, 111, 114, 108, 100 };

            Assert.AreEqual(intArrayTwo, intArray);
        }
    }
}