using Microsoft.VisualStudio.TestTools.UnitTesting;
using Question2;
using System;

namespace Question2Tests
{
    [TestClass]
    public class AudioBookTests
    {
        [TestMethod]
        public void GetHMSShouldReturnTwoHoursForTestAudioBook1()
        {
            Library TestLibrary = new Library();
            TestLibrary.AudioBook.CheckOut(TestLibrary.Daniel);
            Assert.AreEqual("02:00:00", TestLibrary.AudioBook.getHMS());
        }

    }
}
