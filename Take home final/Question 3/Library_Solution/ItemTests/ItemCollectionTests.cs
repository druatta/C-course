using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
        public void TheOlderItemShouldBeAccessibleUsingAnItemCollectionsDictionaryIterator()
        {
            foreach (Item ExampleItem in TestItemCollection)
            {
                Console.WriteLine(ExampleItem.title);
            }
            Assert.Fail();
        }

    }
}
