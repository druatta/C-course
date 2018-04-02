using Microsoft.VisualStudio.TestTools.UnitTesting;
using Question2;

namespace Question2Tests
{
    [TestClass]
    public class MovieTests
    {
        [TestMethod]
        public void TestMovie1ShouldNotBeOnHoldWhenANewLibraryIsCreated()
        {
            Library TestLibrary = new Library();
            Assert.IsFalse(TestLibrary.Movie.isOnHold);
        }

        [TestMethod]
        public void TestMovie1ShouldHaveANullCurrentUserWhenANewLibraryIsCreated()
        {
            Library TestLibrary = new Library();
            Assert.IsNull(TestLibrary.Movie.currentUser);
        }

        [TestMethod]
        public void TestMovie1ShouldBeAvailableWhenALibraryIsCreated()
        {
            Library TestLibrary = new Library();
            Assert.IsTrue(TestLibrary.Movie.isAvailable);
        }

        [TestMethod]
        public void TestMovie1ShouldNotBeAvailableAfterItHasBeenCheckedOut()
        {
            Library TestLibrary = new Library();
            TestLibrary.Movie.CheckOut(TestLibrary.Daniel);
            Assert.IsFalse(TestLibrary.Movie.isAvailable);
        }

        [TestMethod]
        public void Get_HMS_ShouldReturnTwoHoursForTestMovie1()
        {
            Library TestLibrary = new Library();
            TestLibrary.Movie.CheckOut(TestLibrary.Daniel);
            Assert.AreEqual("02:00:00", TestLibrary.Movie.getHMS());
        }
    }
}
