using NUnit.Framework;
using FluentAssertions;
using System;

namespace ITI.Work.Tests
{
    [TestFixture]
    public class FirstTests
    {

        [Test]
        public void yes_we_can()
        {
            var y = new YesWeCan();
            Assert.DoesNotThrow(() => y.Work(), "There is no exception when we work.");
            y.Invoking(sut => sut.Work()).Should().NotThrow("There is no exception when we work.");
        }

        [Test]
        public void an_integer_can_overflow()
        {
            checked
            {
                int i = int.MaxValue + -2;
                i++;
                i++;
                i++;
            }
        }



        [Test]
        public void playing_with_bitflags()
        {
            EngineState state = EngineState.IsRunning
                                | EngineState.IsClutch;

            bool isRunning = state.CheckRunning();

            isRunning.Should().BeTrue();

            state = EngineStateHelper.StopEngine(state);

            isRunning = EngineStateHelper.CheckRunning( state );
            isRunning.Should().BeFalse();

            EngineStateHelper.GetSpeed(state).Should().Be(0);

        }
    }

}
