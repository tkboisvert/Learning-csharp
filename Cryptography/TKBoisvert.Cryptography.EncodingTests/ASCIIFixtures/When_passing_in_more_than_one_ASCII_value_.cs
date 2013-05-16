using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TKBoisvert.Cryptography.Decode;
using NUnit.Framework;
using FluentAssertions;

namespace TKBoisvert.Cryptography.EncodingTests.ASCIIFixtures
{
    [TestFixture]
    class When_passing_in_more_than_one_ASCII_value_
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
