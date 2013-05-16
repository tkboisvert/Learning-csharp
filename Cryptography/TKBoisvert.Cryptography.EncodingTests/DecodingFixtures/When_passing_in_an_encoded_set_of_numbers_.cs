using NUnit.Framework;
using TKBoisvert.Cryptography.Decode;

namespace TKBoisvert.Cryptography.EncodingTests.DecodingFixtures
{
    [TestFixture]
    internal class When_passing_in_an_encoded_set_of_numbers_
    {
        [Test]
        public void should_return_a_decoded_string_of_equal_importance()
        {
            Descrambler descrambler = new Descrambler();

            int[] arrayOfCodedInts = new int[]{169, 202};

            string decodedText = descrambler.ArrayOfASCIIToString(descrambler.Descramble(arrayOfCodedInts, "a")); //array, code word

            Assert.AreEqual("Hi", decodedText);
        }
    }
}