using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Domain.Entities;
using QuickBuy.Domain.Contracts;

namespace QuickBuy.Repository.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IRepositoryProduct
    {

    }
}
