using System;
using Expedia;
using NUnit.Framework;

namespace ExpediaTest
{
	[TestFixture()]
	public class FlightTest
	{
        private readonly DateTime day1 = new DateTime(2012, 3, 11);
        private readonly DateTime day2 = new DateTime(2012, 3, 12);
        private readonly DateTime day3 = new DateTime(2012, 3, 13);
        private readonly DateTime day9 = new DateTime(2012, 3, 19);

		//TODO Task 7 items go here
        [Test()]
        public void TestThatFlightInitializes()
        {
            var target = new Flight(day1, day3, 50);
            Assert.IsNotNull(target);
        }

        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestThatFlightThrowsOnBadTime()
        {
            var target = new Flight(day3, day1, 50);
        }

        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestThatFlightThrowsOnBadMiles()
        {
            var target = new Flight(day1, day3, -5);
        }

        [Test()]
        public void TestFlightHasCorrectBasePriceOneDay()
        {
            var target = new Flight(day1, day2, 50);
            Assert.AreEqual(220, target.getBasePrice());
        }

        [Test()]
        public void TestFlightHasCorrectBasePriceTwoDays()
        {
            var target = new Flight(day1, day3, 50);
            Assert.AreEqual(240, target.getBasePrice());
        }

        [Test()]
        public void TestFlightHasCorrectBasePriceEightDays()
        {
            var target = new Flight(day1, day9, 50);
            Assert.AreEqual(360, target.getBasePrice());
        }

	}
}
