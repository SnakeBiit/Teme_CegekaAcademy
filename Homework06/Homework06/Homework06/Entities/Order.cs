using Homework06.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework06.Entities
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public string Feedback { get; set; }
        public IList<Inventory> Inventories { get; set; }

        Guid IEntity.Id => throw new NotImplementedException();
    }
}
