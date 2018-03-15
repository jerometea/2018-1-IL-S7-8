using NUnit.Framework;
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
            y.Work();
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
