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
            builder.HasKey(users => users.Id);

            builder
                .Property(users => users.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(users => users.Name)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            builder
                .Property(users => users.Password)
                .IsRequired()
                .HasMaxLength(150);
            
            builder
                .Property(users => users.Surname)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");

            /* builder
                .Property(users => users.RequestsItens)
                .IsRequired()
                .HasMaxLength(150); */
        }
    }
}
