using Microsoft.VisualStudio.TestTools.UnitTesting;
using EightQueensPuzzle;
using System;

namespace Unit_tests
{
    [TestClass]
    public class ChessBoardTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgumentExceptionShouldBeThrownIfSideSizeIsTwo()
        {
            int SideSize = 2;
            ChessBoard TestBoard = new ChessBoard(SideSize);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgumentExceptionShouldBeThrownIfSideSizeIsThree()
        {
            int SideSize = 3;
            ChessBoard TestBoard = new ChessBoard(SideSize);
        }

        [TestMethod]
        public void BoardSideSizeShouldMatchUserInputSideSize()
        {
            int SideSize = 8;
            ChessBoard TestBoard = new ChessBoard(SideSize);

            Console.WriteLine("SideSize is {0}", SideSize);
            Console.WriteLine("TestBoard.SideSize is {0}", TestBoard.NumberOfRowsAndColumns);
            Assert.AreEqual(SideSize, TestBoard.NumberOfRowsAndColumns);
        }

    }
}
