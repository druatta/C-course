using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_tests
{
    [TestClass]
    public class Queen
    {
        [TestMethod]
        public void CreateAQueen()
        {
            Queen TestQueen = new Queen();
        }

        [TestMethod]
        public void CheckIfMoveHasFallenOffOfTheBoard()
        {
            Assert.Fail();
        }
    }
}
