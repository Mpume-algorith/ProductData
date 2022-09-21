using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using ProductData.Models;

namespace ProductData.DAL
{
    public class ProductDataContext : DbContext
    {
        public ProductDataContext() : base("ProductDataContext")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}