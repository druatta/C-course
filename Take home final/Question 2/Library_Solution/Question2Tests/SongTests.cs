using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Question2;

namespace Question2Tests
{
    [TestClass]
    public class SongTests
    {
        [TestMethod]
        public void TestSong1ShouldNotBeOnHoldWhenANewLibraryIsCreated()
        {
            Library TestLibrary = new Library();
            Assert.IsFalse(TestLibrary.TestSong1.isOnHold);
        }

        [TestMethod]
        public void TestSong1ShouldHaveANullCurrentUserWhenANewLibraryIsCreated()
        {
            Library TestLibrary = new Library();
            Assert.IsNull(TestLibrary.TestSong1.currentUser);
        }

        [TestMethod]
        public void TestSong1ShouldBeAvailableWhenALibraryIsCreated()
        {
            Library TestLibrary = new Library();
            Assert.IsTrue(TestLibrary.TestSong1.isAvailable);
        }

        [TestMethod]
        public void TestSong1ShouldNotBeAvailableAfterItHasBeenCheckedOut()
        {
            Library TestLibrary = new Library();
            TestLibrary.TestSong1.CheckOut(TestLibrary.Daniel);
            Assert.IsFalse(TestLibrary.TestSong1.isAvailable);
        }

        [TestMethod]
        public void GetHMSShouldReturnFiveSixthsOfAnHourForTestSong1()
        {
            Library TestLibrary = new Library();
            TestLibrary.TestSong1.CheckOut(TestLibrary.Daniel);
            Assert.AreEqual("00:50:00", TestLibrary.TestSong1.getHMS());
        }
    }
}
