using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.ObjectValues;
using System;

namespace QuickBuy.Repository.Config
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(f => f.Id);

            builder
                .Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(f => f.Description)
                .IsRequired()
                .HasMaxLength(100);           
        }
    }
}
