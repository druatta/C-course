using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    class Program
    {
        public static Library TestLibrary = new Library();
        static void Main(string[] args)
        {
            PrintAllUnsortedElementsInTheItemList();

            Console.Read();
        }

        public static void PrintAllUnsortedElementsInTheItemList()
        {
            Console.WriteLine("Printing all unsorted elements in the Item List.");
            foreach (Item ExampleItem in TestLibrary.ExampleItemCollection) {
                Console.WriteLine(ExampleItem);
            }
            Console.WriteLine("Done printing all unsorted elements");
        }
    }
}
