using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Contracts
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity entity);
        TEntity FindById(int id);
        IEnumerable<TEntity> FindAll();
        void Updated(TEntity entity);
        void Remove(TEntity entity);
    }
}
