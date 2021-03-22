using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class ItemFactory
    {
        public readonly string AGED = "Aged Brie";
        public readonly string SULFURAS = "Sulfuras, Hand of Ragnaros";
        public readonly string BACKSTAGE = "Backstage passes to a TAFKAL80ETC concert";
        public readonly string CONJURED = "Conjured Mana Cake";
        public static List<KeyValuePair<string, customItem>> ITEM_LIST;
        public ItemFactory(Item item)
        {
            ITEM_LIST = new List<KeyValuePair<string, customItem>>()
            {
                new KeyValuePair<string, customItem>(AGED,new BrieItem(item)),
                new KeyValuePair<string, customItem>(SULFURAS, new SulfurasItem(item)),
                new KeyValuePair<string, customItem>(BACKSTAGE, new BackstageItem(item)),
                new KeyValuePair<string, customItem>(CONJURED, new ConjuredItem(item)),
            };
        }
        public customItem customize(Item item)
        {
            if (isStandardItem(item))
            {
                return new StandardItem(item);
            }
            var val = ITEM_LIST.FirstOrDefault(x => x.Key == item.Name);
            return val.Value;
        }
        private static bool isStandardItem(Item item)
        {
            var val = ITEM_LIST.FirstOrDefault(x => x.Key == item.Name);
            return !(item.Name == val.Key);
        }
    }
}
