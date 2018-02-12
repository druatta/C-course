using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework3;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SettingGallonsToMinusFourShouldAnThrowArgumentOutOfRangeException()
        {
            Car TestCar = new Car();
            int MinusFour = -4;
            TestCar.Gallons = MinusFour;
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SettingGallonsToSixtyNineShouldAnThrowArgumentOutOfRangeException()
        {
            Car TestCar = new Car();
            int SixtyNine = 69;
            TestCar.Gallons = SixtyNine;
        }

        [TestMethod]
        public void SettingGallonsToTwentyFourShouldBeGucci()
        {
            Car TestCar = new Car();
            int TwentyFour = 24;
            TestCar.Gallons = TwentyFour;
            Assert.AreEqual(TestCar.Gallons, TwentyFour);
        }
    }
}
