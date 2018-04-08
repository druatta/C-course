using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
using System;

namespace ItemTests
{
    [TestClass]
    public class ItemTests
    {
        static Item NewerItem;
        static Item OlderItem;
        static Item AnItemFrom2000;
        static Item AnotherItemFrom2000;
        static Item AnItemWithoutAnAge;

        [ClassInitialize]
        public static void CreateTestItems(TestContext TestContext)
        {
            NewerItem = CreateItemFrom2000();
            OlderItem = CreateItemFrom1990();
            AnItemFrom2000 = CreateItemFrom2000();
            AnotherItemFrom2000 = CreateItemFrom2000();
            AnItemWithoutAnAge = new Item();

        }
        static Item CreateItemFrom2000()
        {
            string NewerItemName = "NewerItem";
            ushort NewerItemYear = 2000;
            return new Item(NewerItemName, NewerItemYear);
        }

        static Item CreateItemFrom1990()
        {
            string OlderItemName = "OlderItem";
            ushort OlderItemYear = 1990;
            return new Item(OlderItemName, OlderItemYear);
        }

        [TestMethod]
        public void CompareToShouldReturnNewerIfTheItemsYearIsGreaterThanComparisonItemsYear()
        {
            Console.WriteLine("Running NewerItem.CompareTo(OlderItem): " +
                "Expected (int)Item.AgeComparison.Newer, which is " + (int)Item.AgeComparison.Newer +
                ". Function return value is " + NewerItem.CompareTo(OlderItem));
            Assert.AreEqual(NewerItem.CompareTo(OlderItem), (int)Item.AgeComparison.Newer);
        }

        [TestMethod]
        public void CompareToShouldReturnOlderIfTheItemsYearIsLessThanTheComparisonItemsYear()
        {
            Console.WriteLine("Running OlderItem.CompareTo(NewerItem): " +
                "Expected (int)Item.AgeComparison.Older, which is " + (int)Item.AgeComparison.Older +
                ". Function return value is " + OlderItem.CompareTo(NewerItem));
            Assert.AreEqual(OlderItem.CompareTo(NewerItem), (int)Item.AgeComparison.Older);
        }

        [TestMethod]
        public void CompareToShouldReturnTheSameYearIfTheItemsYearIsEqualToTheComparisonItemsYear()
        {
            Console.WriteLine("Running ItemFrom2000.CompareTo(AnotherItemFrom2000): " +
                "Expected (int)Item.AgeComparison.TheSameAge, which is " + (int)Item.AgeComparison.TheSameAge +
                ". Function return value is " + NewerItem.CompareTo(AnotherItemFrom2000));
            Assert.AreEqual(NewerItem.CompareTo(AnotherItemFrom2000), (int)Item.AgeComparison.TheSameAge);
        }

        [TestMethod]
        public void CompareToShouldReturnInvalidIfEitherItemDoesntHaveAYear()
        {
            Console.WriteLine("Running ItemFrom200.CompareTo(ItemWithoutAnAge): " +
                "Expected (int)Item.AgeComparison.Invalid, which is " + (int)Item.AgeComparison.Invalid +
                ". Function return value is " + AnItemFrom2000.CompareTo(AnItemWithoutAnAge));
            Assert.AreEqual(AnItemFrom2000.CompareTo(AnItemWithoutAnAge), (int)Item.AgeComparison.Invalid);
        }
    }
}
