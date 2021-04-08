using Homework06.Database;
using Homework06.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework06
{
    public class EntityFrameworkRepository<TEntity> : IRepository<TEntity>, IDisposable 
        where TEntity : class, IEntity
    {
        private readonly DbContext database;

        public EntityFrameworkRepository()
        {
            database = new DealershipContext();
            database.Database.EnsureCreated();
            database.Database.Migrate();
        }

        public void Delete(TEntity entity)
        {
            database.Set<TEntity>().Remove(entity);
            database.SaveChanges();
        }

        public IEnumerable<TEntity> GetByAll()
        {
            return database.Set<TEntity>().AsEnumerable();
        }

        public TEntity GetById(Guid id)
        {
            return database.Set<TEntity>().Find(id);
        }

        public void Insert(TEntity entity)
        {
            database.Set<TEntity>().Add(entity);
            database.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            database.Set<TEntity>().Update(entity);
            database.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
