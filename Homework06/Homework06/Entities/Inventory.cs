using Homework06.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework06.Entities
{
    public class Inventory : IEntity
    {
        public int Id { get; set; }
        public IList<Order> Orders { get; set; }

        Guid IEntity.Id => throw new NotImplementedException();
    }
}
