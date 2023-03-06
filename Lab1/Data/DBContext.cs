using Lab1.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab1.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<Address> Address { get; set; } = default!;
        public DbSet<Customer> Customer { get; set; } = default!;
    }
}
