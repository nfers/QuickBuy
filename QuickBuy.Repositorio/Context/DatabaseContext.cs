using QuickBuy.Domain.Entities;
using QuickBuy.Domain.ObjectValues;
using QuickBuy.Repository.Config;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace QuickBuy.Repository.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestItem> RequestsItems { get; set; }
        public DbSet<Payment> Payments { get; set; }

              
        public DatabaseContext(DbContextOptions options) : base(options)
        {
             
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ///Referencia as classes de mapeamento
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new RequestConfiguration());
            modelBuilder.ApplyConfiguration(new RequestItemConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentConfiguration());

            base.OnModelCreating(modelBuilder);
        }
     
    }
}
