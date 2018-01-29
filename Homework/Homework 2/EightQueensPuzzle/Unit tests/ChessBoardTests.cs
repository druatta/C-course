using Microsoft.VisualStudio.TestTools.UnitTesting;
using EightQueensPuzzle;
using System;

namespace EightQueensPuzzleTests
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

            Console.WriteLine("SideSize is {0}, TestBoard.SideSize is {1}", SideSize, TestBoard.SideSize);
            Assert.AreEqual(SideSize, TestBoard.SideSize);
        }

        [TestMethod]
        public void AFourByFourBoardShouldHaveSixteenBlankSpaces()
        {
            Assert.Fail();
        }


    }
}
