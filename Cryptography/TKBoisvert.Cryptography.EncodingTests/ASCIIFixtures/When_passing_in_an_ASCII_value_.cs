using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TKBoisvert.Cryptography.Core;

namespace TKBoisvert.Cryptography.EncodingTests.ASCIIFixtures
{
    [TestFixture]
    class When_passing_in_an_ASCII_value_
    {
        [Test]
        public void should_return_the_proper_character()
        {
            Descrambler descrambler = new Descrambler();

            string characterReturned = descrambler.ASCIIToString(97);

            Assert.AreEqual("a", characterReturned);
        }
    }
}
