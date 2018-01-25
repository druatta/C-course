using EightQueensPuzzle;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Unit_tests
{
    [TestClass]
    public class PieceTests
    {
        [TestMethod]
        public void APiecesRowNumberShouldNeverBeLessThanOne()
        {
            Assert.Fail();

            int SideSize = 12;
            ChessBoard TestBoard = new ChessBoard(SideSize);


            
        }

        [TestMethod]
        public void APiecesRowNumberShouldNeverBeMoreThanTheNumberOfRowsAndColumns()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void APiecesColumnNumberShouldNeverBeLessThanOne()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void APiecesColumnNumberShouldNeverBeMoreThanTheNmberOfRowsAndColumns()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void AFourByFourBoardShouldHaveSixteenPieces()
        {
            int SideSize = 4;
            ChessBoard TestBoard = new ChessBoard(SideSize);
            int SixteenPieces = 16;
            int ElementCounter;

            ElementCounter = CountEachPieceInTheTestBoard(TestBoard);

            Console.WriteLine("ElementCounter is {0}", ElementCounter);
            Console.WriteLine("SixteenPieces is {0}", SixteenPieces);
            Assert.AreEqual(ElementCounter, SixteenPieces);
        }

        private int CountEachPieceInTheTestBoard(ChessBoard TestBoard)
        {
            int ElementCounter = 0;

            foreach (ChessBoard.Piece Element in TestBoard.RowsAndColumns)
            {
                ElementCounter++;
            }

            return ElementCounter;
        }

        [TestMethod]
        public void AllOfANewBoardsPiecesShouldBeBlank()
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
