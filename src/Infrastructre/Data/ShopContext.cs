using ApplicationCore.Entities;
using Infrastructre.Data.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Infrastructre.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }
         public DbSet<Category> Categories { get; set; }
         public DbSet<Brand> Brands { get; set; }
         public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // https://www.learnentityframeworkcore.com/configuration/fluent-api
            //modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
