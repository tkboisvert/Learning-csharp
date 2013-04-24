using FluentAssertions;
using NUnit.Framework;
using Timer;

namespace TimerTests.SecondFixtures
{
    [TestFixture]
    class When_passing_in_to_many_seconds
    {
        [Test]
        public void should_condense_minutes_to_standard_minute_format()
        {
            int minutes = MinuteAndSecondFormatter.MinuteCondenser(90, 1);

            Assert.AreEqual(2, minutes);
        }
        [Test]
        public void should_condense_seconds_to_standard_second_format()
        {
            int seconds = MinuteAndSecondFormatter.SecondReducer(90, 1);

            Assert.AreEqual(30, seconds);
        }
    }
}
