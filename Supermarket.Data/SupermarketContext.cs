
using Supermarket.Domain.Models;
using SupermarketDomainDtos;
using System.Data.Entity;


namespace Supermarket.Data
{
    public class SupermarketContext : DbContext
    {
        public SupermarketContext() : base("Supermarket") { }

        public SupermarketContext(string connectionString) : base(connectionString)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
