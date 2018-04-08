using System;
using System.Collections.Generic;

namespace Library
{
    public class Item : IComparable
    {
        protected string title;
        protected ushort year;
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

        public string printAuthors
        {
            get
            {
                string s = string.Empty;
                int i = 0;
                while (authors[i] != null)
                {
                    if (i > 0)
                    {
                        s += "; ";
                    }
                    s += authors[i].LastName + ", " + authors[i].FirstName;
                    i++;
                }
                return s;
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

        public void setAuthors(params Author[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                authors.SetValue(a[i], i);
            }
        }

    }
}
