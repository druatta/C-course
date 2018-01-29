using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EightQueensPuzzle;

namespace Unit_tests
{
    [TestClass]
    public class QueenTests
    {
        [TestMethod]
        public void CreatingAQueenShouldNotReturnNull()
        {
            Assert.Fail();

            int SideSize = 4;
            ChessBoard TestBoard = new ChessBoard(SideSize);
            Queen Queen = new Queen(TestBoard);

        }

        [TestMethod]
        public void OneRandomlyPlacedQueenShouldBeFoundOnTheBoard()
        {

            Program TestProgram = new Program();
            TestProgram.RandomlyPlaceAQueen();

            int NumberOfQueens = 0;
            foreach (ChessBoard.Piece Element in TestProgram.ChessBoard.Space)
            {
                if (Element == ChessBoard.Piece.Queen)
                {
                    NumberOfQueens++;
                }
            }

            int One = 1;
            Console.WriteLine("NumberOfQueens is {0}, should be {1}", NumberOfQueens, One);
            Assert.AreEqual(NumberOfQueens, One);
        }


        [TestMethod]
        public void TwoQueensShouldNotBeAbleToBePlacedOnTopOfEachOther()
        {
            Assert.Fail();
        }
    }
}
