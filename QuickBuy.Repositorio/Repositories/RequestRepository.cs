using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Domain.Entities;
using QuickBuy.Domain.Contracts;
using QuickBuy.Repository.Context;

namespace QuickBuy.Repository.Repositories
{
    public class RequestRepository : BaseRepository<Request>, IRequestRepository
    {
        public RequestRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
