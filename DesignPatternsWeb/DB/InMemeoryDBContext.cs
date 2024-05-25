using BusinessLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace DesignPatternsWeb.DB
{
    public class InMemeoryDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "db");
        }
        public DbSet<CustomerDto> Customers { get; set; }
        public DbSet<OrderDto> Orders { get; set; }
    }
}
