using Microsoft.VisualStudio.TestTools.UnitTesting;
using Question2;
using System;

namespace Question2Tests
{
    [TestClass]
    public class AudioBookTests
    {
        [TestMethod]
        public void UserNamedDanielShouldBeAbleToCheckOutAnAvailableTestAudioBook()
        {
            Library TestLibrary = new Library();
            TestLibrary.TestAudioBook.CheckOut(TestLibrary.Daniel);
        }

        [TestMethod]
        public void GetHMSShouldReturnTwoHoursForTestAudioBook()
        {
            Library TestLibrary = new Library();
            TestLibrary.TestAudioBook.CheckOut(TestLibrary.Daniel);
            Assert.AreEqual("02:00:00", TestLibrary.TestAudioBook.getHMS());
        }

    }
}
