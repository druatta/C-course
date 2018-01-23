using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_tests
{
    [TestClass]
    public class Queen
    {
        [TestMethod]
        public void AQueenShouldNotBeAbleToTakeAnother()
        {

        } 

        [TestMethod]
        public void AMoveShouldNotFallOffOfTheBoard()
        {
            Assert.Fail();
        }
        
    }
}
