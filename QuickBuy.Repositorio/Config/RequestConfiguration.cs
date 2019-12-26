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
            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.RequestDate)
                .IsRequired();

            builder
                .Property(p => p.DeliveryDate)
                .IsRequired();

            builder
                .Property(p => p.ZipCode)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .Property(p => p.City)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.State)
                .HasMaxLength(100);

            builder
                .Property(p => p.Address)
                .IsRequired()
                .HasMaxLength(150);

            builder
                .Property(p => p.NumberHouse)
                .IsRequired();
        }
    }
}
