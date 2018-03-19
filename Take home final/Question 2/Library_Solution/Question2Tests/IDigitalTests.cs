using Microsoft.VisualStudio.TestTools.UnitTesting;
using Question2;
using System;

namespace Question2Tests
{
    [TestClass]
    public class IDigitalTests
    {
        [TestMethod]
        public void getHMSShouldReturn7200SecondsForTestAudioBook()
        {
            Library TestLibrary = new Library();
            Console.WriteLine(TestLibrary.TestAudioBook + TestLibrary.TestAudioBook.getHMS());
        }
    }
}
