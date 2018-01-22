using Microsoft.VisualStudio.TestTools.UnitTesting;
using EightQueensPuzzle;

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
        public void EachNewBoardSpaceShouldBeBlank()
        {
            int SideSize = 4;
            ChessBoard TestBoard = new ChessBoard(SideSize);
            foreach (ChessBoard.Piece Element in TestBoard.Matrix)
            {
                Assert.AreEqual(Element, ChessBoard.Piece.Blank);
            }
        }     


    }
}
