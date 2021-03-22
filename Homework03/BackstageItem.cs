using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class BackstageItem : customItem
    {
        public BackstageItem(Item _item) : base(_item){}

        public override void calculateItem()
        {
            if (_item.Quality < 50) _item.Quality++;
            if (_item.SellIn > 5 && _item.SellIn < 10 && _item.Quality <50 ) _item.Quality++;
            if(_item.SellIn < 5 && _item.Quality < 50) _item.Quality++;
            if (_item.Quality > 50) _item.Quality = 50;
            if (_item.SellIn < 0) _item.Quality = 0;
            _item.SellIn--;
        }
    }
}
