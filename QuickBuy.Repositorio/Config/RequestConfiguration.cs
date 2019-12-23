using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Config
{
    public class RequestConfiguration : IEntityTypeConfiguration<Request>
    {          
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            throw new NotImplementedException();
        }
    }
}
