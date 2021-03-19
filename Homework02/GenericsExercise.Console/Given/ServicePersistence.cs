using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace GenericsExercise.Console.Given
{
    public  class ServicePersistence : Persistence
    {
        private readonly IDictionary<string, ICollection<string>> storage;

        public ServicePersistence()
        {
            storage = new Dictionary<string, ICollection<string>>();
        }
        new public Task InsertAsync<TEntity>(TEntity entity) where TEntity : IEntity
        {
            try
            {
                if (
                  string.IsNullOrWhiteSpace(entity.Id) || // Id cannot be empty
                  entity.Id.Contains("%") || // Id cannot contain %
                  entity.Id.Length > 10 // Id cannot be longer than 10 characters
              )
                {
                    throw new ArgumentException("Id is invalid");
                    
                }

                if (!storage.ContainsKey(typeof(TEntity).FullName))
                {
                    storage[typeof(TEntity).FullName] = new List<string>();
                }

                if (storage[typeof(TEntity).FullName].Count >= 3) // there cannot be more than 3 items of a type
                {
                    throw new InvalidOperationException("Cannot insert more than 3 entities of the same type");
                }

                storage[typeof(TEntity).FullName].Add(JsonSerializer.Serialize(entity));
                
            }
            catch(ArgumentException e)
            {
                System.Console.WriteLine("The id should have less than 10 characters, cannot contain % and cannot be null",e.Message);
            }
            catch(InvalidOperationException i)
            {
                System.Console.WriteLine("You cannot insert more than 3 Students or more than 3 Universities!",i.Message);
            }
            return Task.Run(() => { });
        }
        new public Task<IEnumerable<TEntity>> GetAllAsync<TEntity>() where TEntity : IEntity
        {
            try
            {
                
                if (!storage.ContainsKey(typeof(TEntity).FullName))
                {
                    throw new InvalidOperationException("No entities of this type stored");
                }
                return Task.Run(() => storage[typeof(TEntity).FullName].Select(json => JsonSerializer.Deserialize<TEntity>(json)));
            }
            catch (InvalidOperationException i)
            {
                System.Console.WriteLine("You need to store values in database in order to display them",i.Message);
                return null;
            }            
           
            
        }
    }

}

