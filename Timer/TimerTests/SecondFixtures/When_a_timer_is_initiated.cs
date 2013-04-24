using FluentAssertions;
using NUnit.Framework;
using Timer;


namespace TimerTests.SecondFixtures
{
    [TestFixture]
    class When_a_timer_is_initiated
    {
        [Test]
        public void should_count_down_from_specified_Number_to_zero()
        {

           int shouldBeZero = Timers.SecondTimer(0, 0);

           Assert.AreEqual(shouldBeZero, 0);

        }

    }
}
