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
            Assert.IsTrue(TestLibrary.TestAudioBook1.isAvailable); 
        }

        [TestMethod]
        public void TestAudioBook1ShouldNotBeAvailableAfterItHasBeenCheckedOut()
        {
            Library TestLibrary = new Library();
            TestLibrary.TestAudioBook1.CheckOut(TestLibrary.Daniel);
            Assert.IsFalse(TestLibrary.TestAudioBook1.isAvailable);
        }
    }
}
