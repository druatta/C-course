using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace ItemTests
{
    [TestClass]
    public class ItemCollectionTests
    {
        static ItemCollection TestItemCollection;

        [ClassInitialize]
        public static void CreateTestItemCollections(TestContext TestContext)
        {
            TestItemCollection = new ItemCollection();
        }

        [TestMethod]
        public void AllUnsortedItemCollectionElementsShouldBeAccessibleUsingTheForEachIterator()
        {
            string OlderBookAndNewerBookString = TestItemCollection.NewerItemName + TestItemCollection.OlderItemName;
            string TestItemCollectionString = null;

            foreach (Item ExampleItem in TestItemCollection)
            {
                TestItemCollectionString += ExampleItem.title;
            }
            Assert.AreEqual(OlderBookAndNewerBookString, TestItemCollectionString);
        }

        [TestMethod]
        public void TheTextFileWithItemsInItShouldExist()
        {
            Assert.IsTrue(File.Exists(@"C:\Users\Druatta\Documents\GitHub\CSharpCourse\Take home final\Question 4\TextFileWithItemsInIt.txt"));
        }

        [TestMethod]
        public void TheTextFileWithItemsInItShouldHaveThreeLines()
        {
            
            Assert.Fail();
        }

    }
}
