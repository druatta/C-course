using Microsoft.VisualStudio.TestTools.UnitTesting;
using EightQueensPuzzle;

namespace Unit_tests
{
    [TestClass]
    public class QueenTests
    {
        [TestMethod]
        public void AQueenShouldNotBeAbleToTakeAnother()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void AMoveShouldNotFallOffOfTheBoard()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void AQueenShouldNotBeAbleToBePlacedIfThereAreNoBlankSpaces()
        {
            Assert.Fail();

            int NumberOfRows = 7;
            ChessBoard TestBoard = new ChessBoard(NumberOfRows);
            FillTheTestBoardWithQueens(TestBoard);
            TestBoard.AddQueen();
        }

        private void FillTheTestBoardWithQueens(ChessBoard TestBoard)
        {
            for (int i = 0; i < TestBoard.NumberOfRowsAndColumns; i++)
            {
                for (int j = 0; j < TestBoard.NumberOfRowsAndColumns; j++)
                {
                    TestBoard.RowsAndColumns[i, j] = ChessBoard.Piece.Queen;
                }
            }
        }

        [TestMethod]
        public void TheFirstQueenShouldBeAbleToBePlacedAnywhereOnTheBoard()
        {
            Assert.Fail();

            int SideSize = 8;
            ChessBoard TestBoard = new ChessBoard(SideSize);
        }

    }
}
