using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Question2;

namespace Question2Tests
{
    [TestClass]
    public class BookTests
    {
        [TestMethod]
        public void TestAudioBook1ShouldBeAvailableWhenANewLibraryIsCreated()
        {
            Library TestLibrary = new Library();
            Assert.IsTrue(TestLibrary.AudioBook.isAvailable); 
        }

        [TestMethod]
        public void TestAudioBook1ShouldNotBeAvailableAfterItHasBeenCheckedOut()
        {
            Library TestLibrary = new Library();
            TestLibrary.AudioBook.CheckOut(TestLibrary.Daniel);
            Assert.IsFalse(TestLibrary.AudioBook.isAvailable);
        }
    }
}
