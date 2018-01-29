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
        public void ANewEightByEightBoardShouldHaveSixtyFourBlankSpaces()
        {
            int SideSize = 8;
            ChessBoard TestBoard = new ChessBoard(SideSize);

            int NumberOfBlankSpaces = 0;
            foreach (ChessBoard.Piece Element in TestBoard.Space)
            {
                if (Element == ChessBoard.Piece.Blank)
                {
                    NumberOfBlankSpaces++;
                }
            }

            int SixtyFour = 64;
            Console.WriteLine("NumberOfBlankSpaces is {0}, should be {1}", NumberOfBlankSpaces, SixtyFour);
            Assert.AreEqual(NumberOfBlankSpaces, SixtyFour);
        }





    }
}
