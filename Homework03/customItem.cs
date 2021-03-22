using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public abstract class customItem
    {
        public Item _item = new Item();
        public customItem(Item item)
        {
            this._item = item;
        }
        public abstract void calculateItem();
        
    }
}
