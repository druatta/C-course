using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class ItemCollection : IEnumerable
    {
        public Dictionary<ushort, Item> ItemDictionary = new Dictionary<ushort, Item>();
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

        public string OlderItemName = "Older book from 1990";
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

        public string NewerItemName = "Newer book from 2000";
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

        public void SortTheItemCollectionBasedOnYear()
        {
            ItemDictionary.Clear();
            AddTheOlderItemToTheItemDictionary();
            AddTheNewerItemToTheItemDictionary();
        }
    }
}
