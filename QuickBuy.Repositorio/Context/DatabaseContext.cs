using IdentityModel.Client;
using Microsoft.EntityFrameworkCore;
using QuickBuy.Domain.Entities;
using QuickBuy.Domain.ObjectValues;

namespace QuickBuy.Repository.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestItem> RequestsItems { get; set; }
        public DbSet<Payment> Payments { get; set; }

        
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
    }
}
