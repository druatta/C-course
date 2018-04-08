using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class ItemCollection : IEnumerable
    {
        Dictionary<uint, Item> ItemDictionary = new Dictionary<uint, Item>();
        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (Item ExampleItem in ItemDictionary.Values)
            {
                yield return this[ExampleItem.year];
            }
        }

        public Item this[ushort year]
        {
            get { return ItemDictionary[year]; }
            set { ItemDictionary[year] = value; }
        }

        public ItemCollection()
        {
            CreateANewerItem();
            AddTheNewerItemToTheItemDictionary();
            CreateAnOlderItem();
            AddTheOlderItemToTheItemDictionary();
        }

        string OlderItemName = "Older book";
        ushort OlderItemAge = 1990;
        Item OlderItem;
        void CreateAnOlderItem()
        {
            OlderItem = new Item(OlderItemName, OlderItemAge);
        }

        void AddTheOlderItemToTheItemDictionary()
        {
            ItemDictionary.Add(OlderItemAge, OlderItem);
        }

        string NewerItemName = "Newer book";
        ushort NewerItemAge = 2000;
        Item NewerItem;
        void CreateANewerItem()
        {
            NewerItem = new Item(NewerItemName, NewerItemAge);
        }

        void AddTheNewerItemToTheItemDictionary()
        {
            ItemDictionary.Add(NewerItemAge, NewerItem);
        }
    }
}
