using NUnit.Framework;
using TKBoisvert.Cryptography.Core;

namespace TKBoisvert.Cryptography.EncodingTests.ASCIIFixtures
{
    [TestFixture]
    internal class When_passing_in_more_than_one_ASCII_value_
    {
        [Test]
        public void should_return_a_string_of_equivalent_significance()
        {
            Descrambler descrambler = new Descrambler();

            int[] arrayToDecode = new int[] { 97, 98, 99 };

            string decodedArray = descrambler.ArrayOfASCIIToString(arrayToDecode);

            Assert.AreEqual("abc", decodedArray);
        }
    }
}