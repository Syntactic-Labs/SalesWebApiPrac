using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebApiPrac.Models;

namespace SalesWebApiPrac.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder) { }

        public virtual DbSet<Customer> Customers { get; set; }

        public DbSet<SalesWebApiPrac.Models.Order> Order { get; set; }

        public DbSet<SalesWebApiPrac.Models.Orderline> Orderline { get; set; }
    }
}
