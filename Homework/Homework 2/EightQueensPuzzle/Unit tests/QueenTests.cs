using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EightQueensPuzzle;

namespace EightQueensPuzzleTests
{
    [TestClass]
    public class QueenTests
    {
        [TestMethod]
        public void AQueenShouldBeFoundAfterPlacingItOnTheBoard()
        {

            Program TestProgram = new Program();

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
    }
}
