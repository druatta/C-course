using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class ItemCollection : IEnumerable
    {
        Dictionary<uint, Item> ItemDictionary = new Dictionary<uint, Item>();
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ItemDictionary.GetEnumerator();
        }

        public Item this[ushort year]
        {
            get { return ItemDictionary[year]; }
            set { ItemDictionary[year] = value; }
        }
    }
}
