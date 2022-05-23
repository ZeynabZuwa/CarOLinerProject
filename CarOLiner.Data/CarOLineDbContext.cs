using CarOLiner.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOLiner.Data
{
    public class CarOLineDbContext : DbContext
    {
        public CarOLineDbContext(DbContextOptions<CarOLineDbContext> options) : base(options)
        {
            ;
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Variant> Variants { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CarOLineDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
