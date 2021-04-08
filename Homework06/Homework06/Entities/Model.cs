using Homework06.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework06.Entities
{
    public class Model : IEntity
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public int FabricationYear { get; set; }
        public IList<Package> Package { get; set; }
        public IList<Inventory> InventoriesModels { get; set; }

        Guid IEntity.Id => throw new NotImplementedException();
    }
}
