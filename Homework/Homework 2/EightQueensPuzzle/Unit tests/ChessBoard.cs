using Microsoft.VisualStudio.TestTools.UnitTesting;
using EightQueensPuzzle;
using System;

namespace Unit_tests
{
    [TestClass]
    public class TestChessBoard
    {
        [TestMethod]
        public void TestBoardSideSizeShouldMatchUserInputSideSize()
        {
            int SideSize = 3;
            ChessBoard TestBoard = new ChessBoard(SideSize);

            Console.WriteLine("SideSize is {0}", SideSize);
            Console.WriteLine("TestBoard.SideSize is {0}", TestBoard.SideSize);
            Assert.AreEqual(SideSize, TestBoard.SideSize);
        }

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
        public void AFourByFourBoardShouldHaveSixteenPieces()
        {
            int SideSize = 4;
            ChessBoard TestBoard = new ChessBoard(SideSize);
            int SixteenPieces = 16;
            int ElementCounter = 0;

            foreach(ChessBoard.Piece Element in TestBoard.RowsAndColumns)
            {
                ElementCounter++;
            }

            Console.WriteLine("ElementCounter is {0}", ElementCounter);
            Console.WriteLine("SixteenPieces is {0}", SixteenPieces);
            Assert.AreEqual(ElementCounter, SixteenPieces);
        }

        [TestMethod]
        public void EachNewBoardSpaceShouldBeBlank()
        {
            int SideSize = 4;
            ChessBoard TestBoard = new ChessBoard(SideSize);

            foreach (ChessBoard.Piece Element in TestBoard.RowsAndColumns)
            {
                Console.WriteLine("ChessBoard piece element is {0}", Element);
                Assert.AreEqual(Element, ChessBoard.Piece.Blank);
            }
        }

    }
}
