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
            Assert.DoesNotThrow( () => y.Work(), "There is no exception when we work." );
            y.Invoking(sut => sut.Work()).Should().NotThrow("There is no exception when we work.");
        }

        [Test]
        public void an_integer_can_overflow()
        {
            unchecked
            {
                int i = int.MaxValue + 1;
            }
        }



    }
}
