using Homework06.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework06
{
    public class MongoDbRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity
    {
        private readonly IMongoDatabase database;
        private IMongoCollection<TEntity> collection => database.GetCollection<TEntity>(typeof(TEntity).Name);
        public MongoDbRepository()
        {
            var dbClient = new MongoClient("mongodb+srv://admin:admin@cluster0.tkwmr.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            database = dbClient.GetDatabase("Dealership");
        }
        public void Delete(TEntity entity)
        {
            collection.DeleteOne(e => e.Id == entity.Id);
        }

        public IEnumerable<TEntity> GetByAll()
        {
            return collection.Find(e => true).ToEnumerable();
        }

        public TEntity GetById(Guid id)
        {
            return collection.Find(e => e.Id == id).SingleOrDefault();
        } 

        public void Insert(TEntity entity)
        {
            collection.InsertOne(entity);
        }

        public void Update(TEntity entity)
        {
            collection.ReplaceOne(e => e.Id == entity.Id, entity);
        }
    }
}
