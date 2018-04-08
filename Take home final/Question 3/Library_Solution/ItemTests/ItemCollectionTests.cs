using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

    }
}
