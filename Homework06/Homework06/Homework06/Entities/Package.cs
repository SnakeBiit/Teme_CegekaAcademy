using Homework06.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework06.Entities
{
    public class Package : IEntity
    {
        public int Id { get; set; }
        public string PackageName { get; set; }
        public string Engine { get; set; }
        public string Transmision { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public string Features { get; set; }
        public IList<Inventory> InventoriesPackages { get; set; }

        Guid IEntity.Id => throw new NotImplementedException();
    }
}
