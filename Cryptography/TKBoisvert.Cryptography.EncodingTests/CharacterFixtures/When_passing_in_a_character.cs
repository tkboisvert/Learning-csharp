using NUnit.Framework;
using TKBoisvert.Cryptography.Core;

namespace TKBoisvert.Cryptography.EncodingTests
{
    [TestFixture]
    internal class When_passing_in_a_Character_
    {
        [Test]
        public void should_return_char_value_of_the_character()
        {
            Scrambler scrambler = new Scrambler();

            int i = scrambler.ChangeToASCIIValue("a");

            Assert.AreEqual(97, i);
        }
    }
}