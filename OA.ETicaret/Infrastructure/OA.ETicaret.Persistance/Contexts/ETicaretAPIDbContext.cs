using Microsoft.EntityFrameworkCore;
using OA.ETicaret.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.ETicaret.Persistance.Contexts
{
    public class ETicaretAPIDbContext : DbContext
    {
        public ETicaretAPIDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
