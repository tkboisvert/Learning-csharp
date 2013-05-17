using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TKBoisvert.Cryptography.Core;
using NUnit.Framework;
using FluentAssertions;

namespace TKBoisvert.Cryptography.EncodingTests.CharacterFixtures
{
    [TestFixture]
    class When_passing_in_more_than_one_character_
    {
        [Test]
        public void should_return_array_of_ints()
        {
            Scrambler scrambler = new Scrambler();

            int[] intArray = scrambler.ArrayOfASCIIValues("be");

            int[] intArrayTwo = new int[]{98, 101};

            Assert.AreEqual(intArrayTwo, intArray);
        }
    }
}
