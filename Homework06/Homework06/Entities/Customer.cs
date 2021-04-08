using Homework06.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework06.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Adress { get; set; }
        public DateTime? IsInterested { get; set; }
        public IList<Order> Orders { get; set; }

        Guid IEntity.Id => throw new NotImplementedException();
    }
}
