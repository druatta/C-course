using Microsoft.VisualStudio.TestTools.UnitTesting;
using EightQueensPuzzle;

namespace EightQueensPuzzleTests
{
    [TestClass]
    public class QueenTests
    {
        [TestMethod]
        public void TwoQueensShouldNotBeAbleToBePlacedOnTopOfOneAnother()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void AQueenShouldNotBeAbleToBePlacedIfTheBoardIsFull()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void TheFirstQueenShouldBeAbleToBePlacedAnywhereOnTheBoard()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void CheckingForAQueenAfterAddingItToTheBoard()
        {
            Assert.Fail();

            int SideSize = 100;
            ChessBoard TestBoard = new ChessBoard(SideSize);
            TestBoard.TryToAddAQueen();


        }

    }
}
