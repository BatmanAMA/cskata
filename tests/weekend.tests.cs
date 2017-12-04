using System;
using NUnit.Framework;
using kata;

namespace kata.tests
{
    public class weekend_tests
    {

        [Test]
        public void dec2017() => Assert.AreEqual(
                expected: new DateTime(2017, 12, 16, 0, 0, 0),
                actual: weekend.xthDay(3, DayOfWeek.Saturday, new DateTime(2017, 12, 5, 0, 0, 0), null)
            );
        public void sep2011() => Assert.AreEqual(
                expected: new DateTime(2011, 9, 17, 0, 0, 0),
                actual: weekend.xthDay(3, DayOfWeek.Saturday, new DateTime(2011, 9, 1, 0, 0, 0), null)
            );
        [Test]
        public void random()
        {
            DayOfWeek rPatch = (DayOfWeek)((new Random()).Next() % 6);

        }
    }
}