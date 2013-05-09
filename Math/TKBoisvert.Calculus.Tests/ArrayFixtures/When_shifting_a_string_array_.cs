using FluentAssertions;
using NUnit.Framework;
using TKBoisvert.Calculus;

namespace TKBoisvert.Calculus.Tests.ArrayFixtures
{
    [TestFixture]
    class When_shifting_a_string_array_
    {
        [Test]
        public void should_shift_all_strings_up_one_place()
        {
            string[] testArray = new string[3]; testArray[0] = "0"; testArray[1] = "1"; testArray[2] = "2";

            var array = new TKBoisvert.Calculus();

        }
    }
}
