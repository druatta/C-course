using Microsoft.VisualStudio.TestTools.UnitTesting;
using EightQueensPuzzle;
using System;

namespace Unit_tests
{
    [TestClass]
    public class TestChessBoard
    {
        [TestMethod]
        public void SetSideSizeToThreeByThree()
        {
            int SideSize = 3;
            ChessBoard TestBoard = new ChessBoard(SideSize);
            Assert.AreEqual(SideSize, TestBoard.SideSize);
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
            Console.WriteLine("ElementCounter is: {0}", ElementCounter);
            Console.WriteLine("SixteenPieces is: {0}", SixteenPieces);
            Assert.AreEqual(ElementCounter, SixteenPieces);
        }

        [TestMethod]
        public void EachNewBoardSpaceShouldBeBlank()
        {
            int SideSize = 4;
            ChessBoard TestBoard = new ChessBoard(SideSize);
            foreach (ChessBoard.Piece Element in TestBoard.RowsAndColumns)
            {
                Assert.AreEqual(Element, ChessBoard.Piece.Blank);
            }
        }


    }
}
