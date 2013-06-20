using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using FluentAssertions;
using TKBoisvert.Cryptography.Core;

namespace TKBoisvert.Cryptography.EncodingTests
{
    [TestFixture]
    class All_encompassing_test_for_TKC_
    {
        [Test]
        public void should_pass()
        {
            Scrambler scrambler = new Scrambler();

            Descrambler descrambler = new Descrambler();

            UserInteractions ATaP = new UserInteractions();

            int[] arrayOfscrambledCode = scrambler.Scramble("toBeEncoded", "codePhrase");

            int[] scrambledCodePhrase = scrambler.ArrayOfUtf8Values("codePhrase");

            string finalResult = descrambler.ArrayOfASCIIToString(descrambler.Descramble(arrayOfscrambledCode, scrambledCodePhrase));

            Assert.AreEqual("toBeEncoded", finalResult);

        }
    }
}
