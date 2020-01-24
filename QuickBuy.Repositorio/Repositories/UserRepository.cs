using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Domain.Entities;
using QuickBuy.Domain.Contracts;
using QuickBuy.Repository.Context;

namespace QuickBuy.Repository.Repositories
{
    public class UserRepository : BaseRepository<User>, IRepositoryUser
    {
        public UserRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

    }
}
