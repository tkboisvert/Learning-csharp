using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TKBoisvert.Cryptography.Decode;
using FluentAssertions;
using NUnit.Framework;

namespace TKBoisvert.Cryptography.EncodingTests.DecodingFixtures
{
    [TestFixture]
    class When_a_single_string_is_passed_in_
    {
        [Test]
        public void should_descramble_it_with_a_specified_string()
        {
            var descrambler = new Descrambler();

            int[] whatTheTextIsEncoded = new int[] { 197, 199, 201 };

            int[] descrambledNumbers = new int[] { 97, 98, 99 };

            int[] whatTheTextIsDecodedInIntegers = descrambler.Descramble(whatTheTextIsEncoded, "def"); // encoded text, codephrase

            Assert.AreEqual(descrambledNumbers, whatTheTextIsDecodedInIntegers);
        }

    }
}
