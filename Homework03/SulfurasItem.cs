using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class SulfurasItem : customItem
    {
        public SulfurasItem(Item _item) : base(_item){}
        public  override void calculateItem()
        {
            _item.Quality = 80;
        }
    }
}
