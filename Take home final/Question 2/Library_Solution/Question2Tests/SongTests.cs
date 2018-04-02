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
            Assert.IsFalse(TestLibrary.Song.isOnHold);
        }

        [TestMethod]
        public void TestSong1ShouldHaveANullCurrentUserWhenANewLibraryIsCreated()
        {
            Library TestLibrary = new Library();
            Assert.IsNull(TestLibrary.Song.currentUser);
        }

        [TestMethod]
        public void TestSong1ShouldBeAvailableWhenALibraryIsCreated()
        {
            Library TestLibrary = new Library();
            Assert.IsTrue(TestLibrary.Song.isAvailable);
        }

        [TestMethod]
        public void TestSong1ShouldNotBeAvailableAfterItHasBeenCheckedOut()
        {
            Library TestLibrary = new Library();
            TestLibrary.Song.CheckOut(TestLibrary.Daniel);
            Assert.IsFalse(TestLibrary.Song.isAvailable);
        }

        [TestMethod]
        public void GetHMSShouldReturnFiveSixthsOfAnHourForTestSong1()
        {
            Library TestLibrary = new Library();
            TestLibrary.Song.CheckOut(TestLibrary.Daniel);
            Assert.AreEqual("00:50:00", TestLibrary.Song.getHMS());
        }
    }
}
