using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    class Program
    {
        public static Library TestLibrary = new Library();
        static void Main(string[] args)
        {
            PrintAllUnsortedElementsInTheItemList();
            SortAllElementsInTheItemListBasedOnYear();
            PrintAllSortedElementsInTheItemList();
            PrintAllElementsInTheDictionaryCollectionUsingAnIndexer();
            Console.Read();
        }

        public static void PrintAllUnsortedElementsInTheItemList()
        {
            Console.WriteLine("Printing all unsorted elements in the Item List.");
            foreach (Item ExampleItem in TestLibrary.ExampleItemCollection) {
                Console.WriteLine(ExampleItem.title);
            }
            Console.WriteLine();
        }

        public static void SortAllElementsInTheItemListBasedOnYear()
        {
            Console.WriteLine("Sorting all elements in the Item list based on year");
            TestLibrary.ExampleItemCollection.SortTheItemCollectionBasedOnYear();
            Console.WriteLine();
        }

        public static void PrintAllSortedElementsInTheItemList()
        {
            Console.WriteLine("Printing all sorted elements in the Item list.");
            foreach (Item ExampleItem in TestLibrary.ExampleItemCollection)
            {
                Console.WriteLine(ExampleItem.title);
            }
            Console.WriteLine();
        }

        public static void PrintAllElementsInTheDictionaryCollectionUsingAnIndexer()
        {
            Console.WriteLine("Printing all elements in the Dictionary collection using an indexer");
            foreach (Item ExampleItem in TestLibrary.ExampleItemCollection)
            {
                Console.WriteLine(TestLibrary.ExampleItemCollection.ItemDictionary[ExampleItem.year].title);
            }
        }
    }
}
