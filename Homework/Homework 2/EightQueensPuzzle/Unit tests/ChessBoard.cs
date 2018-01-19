using Microsoft.VisualStudio.TestTools.UnitTesting;
using EightQueensPuzzle;

namespace Unit_tests
{
    [TestClass]
    public class TestChessBoard
    {
        [TestMethod] 
        public void CreateAChessBoard()
        {
            ChessBoard TestBoard = new ChessBoard();
        }   
        
        [TestMethod]
        public void EachBoardSpaceShouldBeZero()
        {
            ChessBoard TestBoard = new ChessBoard();
            for (int i = 0; i < TestBoard.SideSize; i++)
            {
                for (int j = 0; j < TestBoard.SideSize; j++)
                {

                }
            }
            Assert.Fail();
        }     

        [TestMethod]
        public void SetBoardSizeToThreeByThree()
        {
            ChessBoard TestBoard = new ChessBoard();
            TestBoard.SideSize = 3;
            Assert.Fail();
        }
    }
}
