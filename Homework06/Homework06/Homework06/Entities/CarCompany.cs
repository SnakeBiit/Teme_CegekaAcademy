using Homework06.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework06.Entities
{
    public class CarCompany : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Model> Models { get; set; }
        public IList<Inventory> InventoriesBrandId{ get; set; }

        Guid IEntity.Id => throw new NotImplementedException();
    }
}
