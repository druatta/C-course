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

        [TestMethod]
        public void AQueenShouldNotBeAbleToBePlacedOnAQueenAttackSpace()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void TwoQueensShouldNotBeAbleToBePlacedInTheSameColumn()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void TwoQueensShouldNotBeAbleToBePlacedInTheSameRow()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void TwoQueensShouldNotBeAbleToBePlacedOnTheSameDownRightDiagonal()
        {
            Assert.Fail();

            /* Pseudocode
             * 1. Create a 4x4 board
             * 2. Add 4 queens
             * 3. Each queen should add its corresponding attack moves
             * 4. During each queen's creation, the queen class should check to make 
             * sure that a queen is not being placed on a queen attack
             * 5. This test then checks each right diagonal (i,j), (i+1,j+1), (i+2,j+2), etc.
             * to make sure there is only one queen in each right diagonal
             */
        }

        [TestMethod]
        public void TwoQueensShouldNotBeAbleToBePlacedOnTheSameDownLeftDiagonal()
        {
            Assert.Fail();
        }
    }
}
