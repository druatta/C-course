using System;
using System.Collections.Generic;

namespace Library
{
    public class Item : IComparable
    {
        public string title;
        public ushort year;
        private Author[] authors = new Author[500];
        private List<Item> PrivateItemList = new List<Item>();

        public List<Item> PublicItemList
        {
            get { return PrivateItemList; }
            set { PrivateItemList = value; }
        }
        public enum AgeComparison : int { Invalid = 0, Newer, Older, TheSameAge };

        public int CompareTo(object ComparisonObject)
        {
            Item ComparisonItem = ComparisonObject as Item;

            if (year == (int)AgeComparison.Invalid || ComparisonItem.year == (int)AgeComparison.Invalid)
            {
                return (int)AgeComparison.Invalid;
            }
            else if (year > ComparisonItem.year)
            {
                return (int)AgeComparison.Newer;
            }
            else if (year < ComparisonItem.year)
            {
                return (int)AgeComparison.Older;
            }
            else if (year == ComparisonItem.year)
            {
                return (int)AgeComparison.TheSameAge;
            }
            else
            {
                throw new InvalidOperationException("New corner case in Item.CompareTo()");
            }
        }

        public Item()
        {
            title = string.Empty;
            year = 0;
            authors[0] = new Author();
        }

        public Item(string t, ushort y)
        {
            title = t;
            year = y;
        }
    }
}
