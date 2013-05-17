using NUnit.Framework;
using TKBoisvert.Cryptography.Core;

namespace TKBoisvert.Cryptography.EncodingTests.DecodingFixtures
{
    [TestFixture]
    internal class When_a_single_string_is_passed_in_
    {
        [Test]
        public void should_descramble_it_with_a_specified_string()
        {
            var descrambler = new Descrambler();

            int[] whatTheTextIsEncoded = new int[] { 197, 199, 201 };

            int[] descrambledNumbers = new int[] { 97, 98, 99 };

            int[] whatTheTextIsDecodedInIntegers = descrambler.Descramble(whatTheTextIsEncoded, new int[] { 100, 101, 102 }); // encoded text, codephrase

            Assert.AreEqual(descrambledNumbers, whatTheTextIsDecodedInIntegers);
        }
    }
}