using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Config
{
    public class RequestItemConfiguration : IEntityTypeConfiguration<RequestItem>
    {          

        public void Configure(EntityTypeBuilder<RequestItem> builder)
        {
            throw new NotImplementedException();
        }
    }
}
