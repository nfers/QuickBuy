using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Domain.Entities;
using QuickBuy.Domain.Contracts;
using QuickBuy.Repository.Context;

namespace QuickBuy.Repository.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IRepositoryProduct
    {
        public ProductRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
    }
}
