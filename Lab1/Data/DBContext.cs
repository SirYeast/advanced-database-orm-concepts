using Lab2.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<Address> Address { get; set; } = default!;
        public DbSet<Customer> Customer { get; set; } = default!;
        public DbSet<CustomerAddress> CustomerAddress { get; set; } = default!;
    }
}
