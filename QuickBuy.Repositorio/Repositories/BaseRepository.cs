using QuickBuy.Domain.Contracts;
using QuickBuy.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Repository.Repositories
{
    public class BaseRepository<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        //permite acesso a base de dados em tempo de execução
        protected readonly DatabaseContext DatabaseContext;

        public BaseRepository(DatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }

        public void Add(TEntity entity)
        {
            DatabaseContext.Set<TEntity>().Add(entity);
            DatabaseContext.SaveChanges();
        }

        public void Dispose()
        {
            DatabaseContext.Dispose();            
        }

        public IEnumerable<TEntity> FindAll()
        {
            return DatabaseContext.Set<TEntity>().ToList();
        }

        public TEntity FindById(int id)
        {
            return DatabaseContext.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity entity)
        {
            DatabaseContext.Remove(entity);
            DatabaseContext.SaveChanges();
        }

        public void Updated(TEntity entity)
        {
            DatabaseContext.Set<TEntity>().Update(entity);
            DatabaseContext.SaveChanges();
        }
    }
}
