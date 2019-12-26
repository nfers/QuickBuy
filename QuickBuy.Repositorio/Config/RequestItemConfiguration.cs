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
            builder
                .HasKey(i => i.Id);

            builder
                .Property(i => i.ProductId)
                .IsRequired();

            builder
                .Property(i => i.Amount)
                .IsRequired();
        }
    }
}
