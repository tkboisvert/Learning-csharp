using FluentAssertions;
using NUnit.Framework;
using Timer;

namespace TimerTests.MinuteFixtures
{
    [TestFixture]
    class When_given_one_minute
    {
        [Test]
        public void should_reduce_minutes_to_zero()
        {
            int minutes = Timers.MinuteTimer(1);

            Assert.AreEqual(0, minutes);
        }

    }
}
