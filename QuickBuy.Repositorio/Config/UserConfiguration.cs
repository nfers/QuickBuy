using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            builder
                .Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(150);
            
            builder
                .Property(u => u.Surname)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            builder
               .HasMany(u => u.Requests)
               .WithOne(p => p.User); //relaciona um unico usuario ao pedido
                
        }
    }
}
