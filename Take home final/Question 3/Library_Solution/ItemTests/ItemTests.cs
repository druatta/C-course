using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
using System;
using System.Collections.Generic;

namespace ItemTests
{
    [TestClass]
    public class ItemTests
    {
        Item CreateItemFrom2000()
        {
            string NewerItemName = "NewerItem";
            ushort NewerItemYear = 2000;
            return new Item(NewerItemName, NewerItemYear);
        }

        Item CreateItemFrom1990()
        {
            string OlderItemName = "OlderItem";
            ushort OlderItemYear = 1990;
            return new Item(OlderItemName, OlderItemYear);
        }

        [TestMethod]
        public void CompareToShouldReturnNewerIfTheItemsYearIsGreaterThanComparisonItemsYear()
        {
            Item NewerItem = CreateItemFrom2000();
            Item OlderItem = CreateItemFrom1990();
            Console.WriteLine("Running NewerItem.CompareTo(OlderItem): " +
                "Expected (int)Item.AgeComparison.Newer, which is " + (int)Item.AgeComparison.Newer +
                ". Function return value is " + NewerItem.CompareTo(OlderItem));
            Assert.AreEqual(NewerItem.CompareTo(OlderItem), (int)Item.AgeComparison.Newer);

        }

        [TestMethod]
        public void CompareToShouldReturnOlderIfTheItemsYearIsLessThanTheComparisonItemsYear()
        {
            Item NewerItem = CreateItemFrom2000();
            Item OlderItem = CreateItemFrom1990();
            Console.WriteLine("Running OlderItem.CompareTo(NewerItem): " +
                "Expected (int)Item.AgeComparison.Older, which is " + (int)Item.AgeComparison.Older +
                ". Function return value is " + OlderItem.CompareTo(NewerItem));
            Assert.AreEqual(OlderItem.CompareTo(NewerItem), (int)Item.AgeComparison.Older);
        }

        [TestMethod]
        public void CompareToShouldReturnTheSameYearIfTheItemsYearIsEqualToTheComparisonItemsYear()
        {
            Item ItemFrom2000 = CreateItemFrom2000();
            Item AnotherItemFrom2000 = CreateItemFrom2000();
            Console.WriteLine("Running ItemFrom2000.CompareTo(AnotherItemFrom2000): " +
                "Expected (int)Item.AgeComparison.TheSameAge, which is " + (int)Item.AgeComparison.TheSameAge +
                ". Function return value is " + ItemFrom2000.CompareTo(AnotherItemFrom2000));
            Assert.AreEqual(ItemFrom2000.CompareTo(AnotherItemFrom2000), (int)Item.AgeComparison.TheSameAge);
        }

        [TestMethod]
        public void CompareToShouldReturnInvalidIfEitherItemDoesntHaveAYear()
        {
            Item ItemFrom2000 = CreateItemFrom2000();
            Item ItemWithoutAnAge = new Item();
            Console.WriteLine("Running ItemFrom200.CompareTo(ItemWithoutAnAge): " +
                "Expected (int)Item.AgeComparison.Invalid, which is " + (int)Item.AgeComparison.Invalid +
                ". Function return value is " + ItemFrom2000.CompareTo(ItemWithoutAnAge));
            Assert.AreEqual(ItemFrom2000.CompareTo(ItemWithoutAnAge), (int)Item.AgeComparison.Invalid);
        }

        [TestMethod]
        public void CreatingAPublicItemListShouldDoSomethingButIDontKnowWhat()
        {
            Item TestItem = new Item();
            TestItem.PublicItemList = new List<Item>();
            Assert.Fail();
        }



    }
}
