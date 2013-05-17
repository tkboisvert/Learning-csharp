using NUnit.Framework;
using TKBoisvert.Cryptography.Core;

namespace TKBoisvert.Cryptography.EncodingTests.DecodingFixtures
{
    [TestFixture]
    internal class When_a_string_of_mutiple_three_digit_numbers_is_passed_in_
    {
        [Test]
        public void should_return_an_array_of_the_same_three_digit_numbers()
        {
            var changeToCodedArray = new Change();

            int[] array = changeToCodedArray.ToCodedArray("123 456 789");

            Assert.AreEqual(new int[] { 123, 456, 789 }, array);
        }
    }
}